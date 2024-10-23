#!/bin/bash
#
# Description: Generate the Symend Customer API HTTP client from an OpenAPI specification
#
# @author Brian Cowdery
# @since 22-Oct-2024

# colors
red='\e[1;31m%s\e[0m'
green='\e[1;32m%s\e[0m'
yellow='\e[1;33m%s\e[0m'

help()
{
    echo "Generate the Symend Customer API HTTP client from an OpenAPI specification."
    echo 
    echo "Syntax: $(basename $0) -d"
    echo "Options:"
    echo "  -h              Show help"
    echo "  -d              Delete existing files"
    echo
    echo "Examples: "
    echo "  ./$(basename $0) -d"
}

while getopts ":hd" option; do
    case $option in
        h) # display help
            help
            exit;;
        
        d) # delete existing files
            DELETE=true
            ;;
            
        \?) # Invalid option
            echo "Error: Invalid option, -h to show help."
            exit;;
    esac
done

main()
{
    # delete old files
    if [[ $DELETE == "true" ]]; then
        echo "Deleting existing files..."

        rm -rf Symend.Client.Customer/api
        rm -rf Symend.Client.Customer/docs
        rm -rf Symend.Client.Customer/src
    fi

    # regenerate the client
    echo "Generating OpenAPI client ..."

    openapi-generator-cli generate \
        -g csharp \
        -i customer.v1.yaml \
        -c customer.v1.cfg.yaml \
        -o Symend.Client.Customer

    # cleanup reserved word renaming to prefer underscore prefix
    echo "Cleaning up reserved words ..."

    for f in Symend.Client.Customer/docs/*.md; do
        sed -i "s/VarVersion/_Version/g" "$f"
        sed -i "s/VarOperator/_Operator/g" "$f"
    done

    for f in Symend.Client.Customer/src/Symend.Client.Customer/Model/*.cs; do
        sed -i "s/VarVersion/_Version/g" "$f"
        sed -i "s/VarOperator/_Operator/g" "$f"
    done

    for f in Symend.Client.Customer/src/Symend.Client.Customer.Test/Model/*.cs; do
        sed -i "s/VarVersion/_Version/g" "$f"
        sed -i "s/VarOperator/_Operator/g" "$f"
    done

    printf "$green\n" "Done ✔"
}

main
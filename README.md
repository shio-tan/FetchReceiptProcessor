Project can be built/run using:

docker build -f "<PATH>\FetchReceiptProcessor\FetchReceiptProcessor\Dockerfile" --force-rm -t fetchreceiptprocessor  --build-arg "BUILD_CONFIGURATION=Release" "<PATH>\FetchReceiptProcessor"

docker run fetchreceiptprocessor

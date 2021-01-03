# Generate a private key for the signing process
openssl genrsa -passout pass:foobar -out server.key 1024

# Sign the CSR with the private key to obtain the .CER file
openssl x509 -req -days 3650 -in local.devbg.org.csr -signkey server.key -passin pass:foobar -out local.devbg.org.crt

# Export the certificate with private key as PKCS#12 (pfx file)
openssl pkcs12 -export -in local.devbg.org.crt -inkey server.key -passin pass:foobar -out local.devbg.org.pfx -passout pass:foobar -name "local.devbg.org"

pause

FROM ubuntu

RUN apt-get update && apt-get install -y dos2unix
RUN apt-get update && apt-get install -y curl

COPY ./runtest.sh /tests/runtest.sh
RUN dos2unix /tests/runtest.sh
RUN chmod +x /tests/runtest.sh

WORKDIR /tests

ENTRYPOINT ["./runtest.sh"]

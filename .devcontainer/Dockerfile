FROM mcr.microsoft.com/devcontainers/base:bullseye

RUN curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel 8.0

# Install SQL Tools: SQLPackage and sqlcmd
COPY scripts/installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
     && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts

# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1

# Add .NET SDK to path
RUN echo "export PATH=\"$PATH:/root/.dotnet\"" >> ~/.bashrc

# Add .NET global tools to path
RUN echo "export PATH=\"$PATH:/root/.dotnet/tools\"" >> ~/.bashrc

# Generate the dev cert
RUN dotnet dev-certs https
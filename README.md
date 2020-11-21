# dotnet_shell_practical


# install
```
dotnet tool install fake-cli -g
echo PATH=$PATH:$HOME/.dotnet/tools >> ~/.bash_profile

# show fake-template for create Fakefile.
dotnet new -i "fake-template::*"

# create fake template
dotnet new fake

```
# Reference

[dotnet tools](https://docs.microsoft.com/ja-jp/dotnet/core/tools/dotnet-tool-install)
[Fake fsharp script build tool](https://fake.build/fake-gettingstarted.html)
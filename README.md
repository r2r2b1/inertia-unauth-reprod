#inertia-unauth-reprod

This repo is for reproducing the [How to handle unauthorized route?](https://github.com/kapi2289/InertiaCore/issues/15) issue on [InertiaCore](https://github.com/kapi2289/InertiaCore) nuget package.

## Steps

1 - Initialized the project using `dotnet new mvc`

2 - Initialized simple vite vue project and changed the config by following the [InertiaCore](https://github.com/kapi2289/InertiaCore) readme.

- Borrowed `src/app.js` & `src/bootstrap.js` files from Laravel
- Also added simple pages for the demo

3 - Installed [InertiaCore](https://github.com/kapi2289/InertiaCore) package and added `AddInertia`, `AddViteHelper` services and added `UseInertia` middleware

- Also changed [HomeController](./Controllers/HomeController.cs) to render inertia pages.

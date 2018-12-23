# FNA Test Project
This repository contains a small FNA-powered 'game' for testing our additional framework features. We use this for actually working in the FNA codebase as it allows us to build and test our changes immediately in VS. If you want to modify the framework code, this is the project you want to really want to clone.

There is a testing game for 2D and 3D, which build in the same executable but use separate `Game` classes. A command-line prompt allows you to choose which to run on startup.

## Building
This project will just build from VS/VSCode as is assumbing you properly initialised all submodules (FNA uses them extensively). It requires .NET Framework 4.7.1 or a version of Mono supporting this .NET version.

## License
This project is licensed under the MIT license. See LICENSE for more details.
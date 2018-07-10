# Python

## pyenv-virtualenv

Docs are available:

* [pyenv virtualenv](https://github.com/pyenv/pyenv-virtualenv)
* [pyenv](https://github.com/pyenv/pyenv)
* [virtualenv](https://virtualenv.pypa.io/en/stable/)

To create a new enviornment using virtualenv,  
`pyenv virtualenv <version> <name>`

Some go-to's:

* `pyenv virtualenv 2.7.10 env-2.7.10`
* `pyenv virtualenv 3.7.0 env-3.7.0`

To activiate a virtual enviortment use,  
`pyenv activate <name>`  
Or to deactiviate,  
`pyenv deactivate`

To install a new version of python,  
`pyenv install <version>`

**Note:**  
Ensure the following 2 statements are added to `~/.bash_profile`  
`eval "$(pyenv init -)"`  
`eval "$(pyenv virtualenv-init -)"`  
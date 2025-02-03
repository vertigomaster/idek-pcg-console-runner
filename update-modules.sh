git submodule update --init --recursive
git submodule foreach git pull origin main
git submodule foreach git checkout main
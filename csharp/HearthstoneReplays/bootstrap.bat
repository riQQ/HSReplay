mkdir "git_tmp"
git clone --depth=1 "https://github.com/HearthSim/HearthDb.git" "git_tmp"
rm -r -f "HearthDb/Enums"
mv "git_tmp/HearthDb/Enums" "HearthDb"
rm -r -f "git_tmp"
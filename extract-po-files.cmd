#
# It's assumed that POTools from https://github.com/xecrets/aspnetskeleton2 is installed in %UserProfile%\Documents\contrib\xfcli\POTools
#
pushd src\Xecrets.Texts
%UserProfile%\Documents\contrib\xfcli\POTools extract -p Properties -m -i Properties\Resources.resx -l it-IT -l sv-SE -l fr-FR -l de-DE -l es-ES -l pl-PL --no-backup -o Translations\xecrets-ez.pot
if errorlevel 1 pause
popd

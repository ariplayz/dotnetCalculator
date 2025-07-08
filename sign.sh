#!/bin/sh

###########################################################################################################
###########################################################################################################
###
### Copyright 2025, The Lackner Group, Inc.
###
### Purpose:        Submits for notarization & 'staples' each of the files, places notarized copy
###                 in the '_ Signed' folder.
###
### Usage & Notes:  This assumes a valid Developer ID certificate is installed, and the Packages have
###                 all been compiled using that Developer ID Installer cert.
##                 
### Revisions:      2024.12.20 - Andrew Cummings; Created.
###
###########################################################################################################
###########################################################################################################

# Setup variables
fmVer="21.1.1"
dateStamp="20250626"
dbVer="2025-097"
appleID="andrew@artistechendeavors.com"
password="voqy-gjtn-qqzv-jnap"
teamID="XLA5QQ65S8"

# Verify signed folder
sgn="_ Signed"
if [ ! -e "${sgn}" ] ; then
    mkdir -p "${sgn}"
    chmod -R 777 "${sgn}"
fi
echo
echo "************************************************************"
echo


# For each set of files... we'll assume they each been newly built.  Copy to signed folder, then sign.
src="FileMaker Pro 2024 for Lackner Software.pkg"
dst="fmp_Mac_ForLacknerSoftware_v${fmVer}_${dateStamp}.pkg"
echo BEGIN: $dst 
if [ -e "${sgn}/${dst}" ] ; then
   rm "${sgn}/${dst}"
fi
cp "${src}" "${sgn}/${dst}"
xcrun notarytool submit "${sgn}/${dst}" --apple-id "${appleID}" --password "${password}" --team-id "${teamID}" --wait
xcrun stapler staple "${sgn}/${dst}"
echo DONE: $dst 
echo
echo "************************************************************"
echo


src="6-in-1 Standalone All-In-One (v${dbVer}).pkg"
dst="fmp_Mac_For6in1_v${fmVer}_${dateStamp}_AllInOne_${dbVer}.pkg"
echo BEGIN: $dst 
if [ -e "${sgn}/${dst}" ] ; then
    rm "${sgn}/${dst}"
fi
cp "${src}" "${sgn}/${dst}"
xcrun notarytool submit "${sgn}/${dst}" --apple-id "${appleID}" --password "${password}" --team-id "${teamID}" --wait
xcrun stapler staple "${sgn}/${dst}"
echo DONE: $dst 
echo
echo "************************************************************"
echo


src="6-in-1 Server Database (v${dbVer}).pkg"
dst="6in1-${dbVer}-v20-Server-${dateStamp}.pkg"
echo BEGIN: $dst 
if [ -e "${sgn}/${dst}" ] ; then
    rm "${sgn}/${dst}"
fi
cp "${src}" "${sgn}/${dst}"
xcrun notarytool submit "${sgn}/${dst}" --apple-id "${appleID}" --password "${password}" --team-id "${teamID}" --wait
xcrun stapler staple "${sgn}/${dst}"
echo DONE: $dst 
echo
echo "************************************************************"
echo


src="6-in-1 Standalone Database (v${dbVer}).pkg"
dst="6in1-${dbVer}-v20-Standalone-${dateStamp}.pkg"
echo BEGIN: $dst 
if [ -e "${sgn}/${dst}" ] ; then
    rm "${sgn}/${dst}"
fi
cp "${src}" "${sgn}/${dst}"
xcrun notarytool submit "${sgn}/${dst}" --apple-id "${appleID}" --password "${password}" --team-id "${teamID}" --wait
xcrun stapler staple "${sgn}/${dst}"
echo DONE: $dst 
echo
echo "************************************************************"
echo
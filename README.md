# Eyegaze-Mrtk-Vuforia-Tests
Testing eyegaze function in HoloLens2 with other stuff (Unity)

## Note
Because vuforia package is too large for git, used personal dropbox as LFS with [lfs-folderstore](https://github.com/sinbad/lfs-folderstore) and treat tgz packages as large files.

## Link
Corresponding LFS folder dropbox link for this project:
[LFS-folder of Eyegaze-Mrtk-Vuforia-Tests](https://www.dropbox.com/sh/ayqzlvbr0dtuw3j/AACzSGU1CWPsZelnRuFLXgFya?dl=0)

###### ---
For more information how to configure Git LFS to use in dropbox, refer to this [tutorial](https://weirdbearddev.com/resources/learning/configuring-git-lfs-to-use-dropbox/); i.e. Clone An Existing Repo section.

###### Reminder: In Unity Build Settings, switch platform to UWP. Finally, open EyeAndImageTrackingScene.

###### Sometimes in cloning this repo, `git config --unset` returns an invalid key error. As a workaround for this problem, run `git config --edit` and manually remove lfs github link and parameters.
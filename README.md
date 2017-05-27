# EndlessAges.Unity.Client

This is a repository that contains a Unity3D project for an Endless Ages client. It is not yet decided whether this client will be for a remake or a reverse engineered replacement for the current closed-source Endless Ages client.

For more information on the Endless Ages Opensource Iniative check out the [Information Page](https://github.com/Endlessages/Information)

## Setup

* [Unity3D](https://unity3d.com/) version 5.6.0f3 or later.

## Directory Structure

### Main

**Code:** The majority of components will be in DLLs however the occasional demo script or test script may be present and it belongs in Code.

**Content:** The content folder is the most important folder in the project. It and its subfolders contains the bulk of assets related to the project. There is a **Common** and **Zone** subfolder within it. Common is similar to a Zone subfolder such that common elements accross not only all zones but all other Content folders will reside in Common. the **Zone** folder enumerates all zone specific content in labeled subfolders. For example the NewbieTown subfolder contains Buildings, Enviroment, Common and other asset subfolders that make up the content seen in the Newbietown. Adhering to this structure is critical for longterm or large projects. Organization of content is important for git, for the art and asset pipeline and more.

**Scenes:** Any scenes you create should be put in Scenes. No more organizational guidance other than that is advised at this time.

### Misc

**PostProcessing:** Unity Technologies' uber post stack library from the Unity3D asset store. Do not remove or put anything inside of this folder.

**Textures:** Contains assorted exported texture data from the Endless Ages client. It is a staging area for any exported content and should not be directly references by content or scenes. It is only a staging ground.

**Frames:** Similar to **Textures** this is an assorted exported frame data. Frame data contains draw calls that contain Endless Ages' mesh data that is used to recreate the levels and scenes. Usually this content should not be present in Unity3D as it need to go through the asset pipeline before it is ready for production use.

## Asset Pipeline

The pipeline for bringing in content from Endless Ages is not without a burden of work. Without access to the original data we must use techniques to extract, fix, cleanup and prepare for use the content present in Endless Ages. Below is a description of the recommended process.

TODO

## Licensing

MIT

# Animalandia
 AppDev C# Web App using ASP.Net

To Run:

Download Visual Studio~
1. Download the Visual Studio Installer (Community)
- https://visualstudio.microsoft.com/downloads/
2. Run the Installer
3. Select Visual Studio Community 2022
4. Check "ASP.NET and web development"
5. Look at the installation details and check ".Net Framework project and item templates".
6. Install

Visual Studio~
Depende sa trip niyo, options are:
1. Clone niyo tong repo
2. Open tong project or "solution"
3. Create new project
   a. Select "ASP.NET Web Application (.Net Framework) - make sure na for C# and not for Visual Basic
   b. Next
   c. Preferably name for both project and solution is 'Animalandia' and framework is 4.8 since yon gamit ko for sure paths if ever
   d. Create
   e. Select MVC
   f. Create— alaws na babaguhin
   
For options 2 and 3 - download the repository as ZIP file
1. go to repository
2. green "Code" Button
3. Download as ZIP File
4. Extract san niyo trip

Option 2 - Vistual Studio
1. Find and Select lang "Animalandia.sln" sa downloaded repo
2. goods na yan
   
Option 3 - Vistual Studio
1. Go to the created project folder
2. Copy lng laman nung nasa downloaded repo - Animalandia > Animalandia (or name nung Solution na nilagay sa settings) folder and paste sa created project
3. goods na yan if goods steps

===========================================================================

File Heirarchy nung sa Visual Studio (Solution Explover/View)
```
└── Animalandia
    ├── Connected Services
    ├── Properties
    ├── References
    ├── App_Data
    ├── App_Start
    │   ├── BundleConfig.cs
    │   ├── FilterConfig.cs
    │   └── RouteConfig.cs
    ├── Content
    │   ├── css/
    │   │   └── styles.css
    │   ├── images/
    │   │   └── logo.png
    │   └── fonts/
    ├── Controllers
    │   ├── GalleryController.cs
    │   └── HomeController.cs
    ├── Models
    │   ├── AnimalModel.cs
    │   └── GalleryModel.cs
    ├── Scripts
    │   └── main.js
    ├── Views
    │   ├── Animals
    │   │   ├── AquaticAnimals.cshtml
    │   │   ├── Birds.cshtml
    │   │   ├── FarmAnimals.cshtml
    │   │   ├── Insects.cshtml
    │   │   ├── Pets.cshtml
    │   │   └── WildAnimals.cshtml
    │   ├── Home
    │   │   ├── AboutUs.cshtml
    │   │   ├── FarmAnimals.cshtml
    │   │   ├── Gallery.cshtml
    │   │   └── Index.cshtml
    │   ├── Shared
    │   │   ├── _AnimalsLayout.cshtml
    │   │   ├── _Layout.cshtml
    │   │   ├── Error.cshtml
    │   │   └── _ViewStart.cshtml
    ├── favicon.ico
    ├── Global.asax
    ├── packages.config
    └── Web.config
```

Some Deets:
```
    ├── App_Start
    │   ├── BundleConfig.cs
```
- dito mag include ng like specific files na need sa project. 
- gumagamit siya bootstrap so include na yung iba na nasa content folder + yung Site.css. 
- If trip niyo mag-add additional css file, dito ilalagay. Tho, i suggest not kase pwede nmn na don sa Site.css.

```
    ├── Content
```
- stuffs like images, fonts, and css (both bootstrap framework and Site.css for customized styles) ay dito nakalagay.

```
    ├── Scripts
```
- as the name implies, scripts laman niya. wala ako masyado ginalaw, d nmn ako marunong mag js. pero kung bet niyo, pwede kayo mag-add.
- just make sure na i-add niyo don sa BundleConfig.cs, under boostrap bundle, para masmadali ma-manage.

```
    ├── Controllers
    │   ├── GalleryController.cs
    │   └── HomeController.cs
```
- dito mag-configure nung sa file paths. madali lang siya since yung project framework na mismo nagha-handle.

```
    ├── Views
    │   ├── Animals
    │   │   ├── AquaticAnimals.cshtml
    │   │   ├── Birds.cshtml
    │   │   ├── FarmAnimals.cshtml
    │   │   ├── Insects.cshtml
    │   │   ├── Pets.cshtml
    │   │   └── WildAnimals.cshtml
```
- yung sa laman ng gallery, individual animal categories. gamit netong layout is _AnimalsLayout.cshtml
- dito i-edit yung content nila. pero balak ko is gawan ng template din and somehow i-implement polymorphism construct or ket anong OOP principles.

```
    │   ├── Home
    │   │   ├── AboutUs.cshtml
    │   │   ├── FarmAnimals.cshtml
    │   │   ├── Gallery.cshtml
    │   │   └── Index.cshtml
```
- name, ayon. gamit niyang layout is _Layout.cshtml.

```
    │   ├── Shared
    │   │   ├── _AnimalsLayout.cshtml
    │   │   ├── _Layout.cshtml
```
- to naman yung parang sa layout templating. dito din mina-manage yung styles, scripts, etc. na gagamitin nung pages na gumagamit sa certain layouts. 

```
    ├── favicon.ico
```
- icon nung website sa web, baka trip niyo palitan.




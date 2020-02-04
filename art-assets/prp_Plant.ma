//Maya ASCII 2019 scene
//Name: prpPlant.ma
//Last modified: Mon, Jan 20, 2020 12:25:59 PM
//Codeset: 1252
requires maya "2019";
requires "mtoa" "3.1.2";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 10 Technical Preview  (Build 17134)\n";
fileInfo "license" "education";
createNode transform -s -n "persp";
	rename -uid "37BF2324-488C-EF06-3EE3-27A8F7660F97";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1.750778537548193 2.4330070529733332 9.3816395098773366 ;
	setAttr ".r" -type "double3" -4.5383527295021393 11.799999999998304 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "D0A07BA2-4C00-EA2E-39C7-2F982DB9246F";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 9.9836949360069056;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "EC2A0A0C-4E3F-FC11-9B10-0E9B1B409AD2";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "8C9890CC-4E2A-428A-FFC5-3EB618AC580E";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "4A76542D-4CF7-E3D0-F857-33A8D46C020A";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "92A49D65-420F-A5B5-05C2-9F9180F5D84E";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "1134B534-41CC-E952-9628-F3AE0C8F15F1";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "AB39C236-4261-59FB-72EF-8D9736C452A0";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "prpPlant";
	rename -uid "0748A24A-4DC2-2318-43EE-509DAA388058";
createNode transform -n "prpPlant" -p "|prpPlant";
	rename -uid "CF537A16-4CF7-290A-555F-F4BDCADC46DB";
	setAttr ".t" -type "double3" 0 0.5414758168526157 0 ;
	setAttr ".s" -type "double3" 0.53759638560006306 0.53759638560006306 0.53759638560006306 ;
createNode mesh -n "prpPlantShape" -p "|prpPlant|prpPlant";
	rename -uid "5A4B2B4D-466E-F1E8-C29F-8E9003E005F3";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.53906252980232239 0.84375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "38AAB46D-42AF-9716-15A2-5B9A386F91CB";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "725FEED1-47AC-9813-5D7B-9BB441E030C4";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "CDA0A3B3-4111-7E0E-E136-D49E532FF50F";
createNode displayLayerManager -n "layerManager";
	rename -uid "78664BC1-4C6F-C4C2-D20E-558987E480E9";
createNode displayLayer -n "defaultLayer";
	rename -uid "70D6AAE2-4413-3244-E826-488497A7EDD2";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "C8433991-4A09-F297-7F92-C7B2F09E723F";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "96AE8DA7-488F-3A13-7DC2-DF83656F7040";
	setAttr ".g" yes;
createNode polyCylinder -n "polyCylinder1";
	rename -uid "108FD157-406E-6C69-2912-5CB8E27F5357";
	setAttr ".sa" 6;
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "6BE21389-4A1F-E689-86AF-ED84293502F0";
	setAttr ".ics" -type "componentList" 1 "f[12:17]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.84584242 0 ;
	setAttr ".rs" 49916;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.72461984132762747 0.84584242438659851 -0.62753926538782401 ;
	setAttr ".cbx" -type "double3" 0.72461984132762747 0.84584242438659851 0.62753926538782401 ;
createNode polyTweak -n "polyTweak1";
	rename -uid "72B5D854-45A4-C4D0-7F56-72891C0FCDE3";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk";
	setAttr ".tk[6]" -type "float3" 0.17394422 -0.43383807 -0.30128008 ;
	setAttr ".tk[7]" -type "float3" -0.17394412 -0.43383807 -0.30128011 ;
	setAttr ".tk[8]" -type "float3" -0.34788829 -0.43383807 -4.1471516e-08 ;
	setAttr ".tk[9]" -type "float3" -0.17394421 -0.43383807 0.30128011 ;
	setAttr ".tk[10]" -type "float3" 0.17394413 -0.43383807 0.30128014 ;
	setAttr ".tk[11]" -type "float3" 0.34788829 -0.43383807 1.0367878e-08 ;
	setAttr ".tk[13]" -type "float3" 0 -0.43383807 1.0367878e-08 ;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "5DA6BE9F-431D-2DDC-6653-0E8AA3DC0414";
	setAttr ".ics" -type "componentList" 1 "f[12:17]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.84584248 0 ;
	setAttr ".rs" 64671;
	setAttr ".lt" -type "double3" 1.3234889800848443e-23 -9.7171975396676733e-17 -0.15265954511679147 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.62185857543116196 0.84584245642984013 -0.53854537824317683 ;
	setAttr ".cbx" -type "double3" 0.62185857543116196 0.84584245642984013 0.53854537824317683 ;
createNode polyTweak -n "polyTweak2";
	rename -uid "6C478D5D-4931-A42B-55E7-96B49B97D1BB";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk[13:19]" -type "float3"  -0.095574766 0 0.16554032
		 0.095574722 0 0.16554037 0 0 -1.4703103e-09 0.19114947 0 2.7013195e-08 0.095574751
		 0 -0.16554032 -0.095574737 0 -0.16554037 -0.19114947 0 -1.4703103e-09;
createNode polyExtrudeFace -n "polyExtrudeFace3";
	rename -uid "9ADAC0B0-4528-9689-1E83-8DB0C85B327F";
	setAttr ".ics" -type "componentList" 1 "f[12:17]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.69318295 0 ;
	setAttr ".rs" 51894;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.54205475406279557 0.69318294202786634 -0.46943320099553187 ;
	setAttr ".cbx" -type "double3" 0.54205475406279557 0.69318294202786634 0.46943320099553187 ;
createNode polyTweak -n "polyTweak3";
	rename -uid "CB9B51AF-43FF-1084-1433-1DA9C08039DE";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk[19:25]" -type "float3"  -0.074222855 -5.5511151e-17
		 0.1285577 0.074222796 -5.5511151e-17 0.12855773 -3.1593372e-24 -5.5511151e-17 -1.1418352e-09
		 0.14844561 -5.5511151e-17 2.097828e-08 0.074222855 -5.5511151e-17 -0.1285577 -0.074222803
		 -5.5511151e-17 -0.12855773 -0.14844561 -5.5511151e-17 -1.1418352e-09;
createNode polyExtrudeFace -n "polyExtrudeFace4";
	rename -uid "015B2356-4C65-43B0-EB4D-1DBBBF408901";
	setAttr ".ics" -type "componentList" 1 "f[12:17]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.69318295 0 ;
	setAttr ".rs" 50391;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.069702253541639489 0.69318294202786634 -0.060363891643251441 ;
	setAttr ".cbx" -type "double3" 0.069702253541639489 0.69318294202786634 0.060363891643251441 ;
createNode polyTweak -n "polyTweak4";
	rename -uid "562397FC-4FB7-C609-07D1-6DA19D94AC65";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk[25:31]" -type "float3"  -0.43931916 -6.1062266e-16
		 0.76092273 0.43931878 -6.1062266e-16 0.76092273 -1.869987e-23 -6.1062266e-16 -6.7584294e-09
		 0.87863779 -6.1062266e-16 1.2416876e-07 0.43931904 -6.1062266e-16 -0.76092273 -0.4393189
		 -6.1062266e-16 -0.76092273 -0.87863779 -6.1062266e-16 -6.7584294e-09;
createNode polyExtrudeFace -n "polyExtrudeFace5";
	rename -uid "333023E2-48B5-B16E-F9B5-218C6E39A3D3";
	setAttr ".ics" -type "componentList" 1 "f[12:17]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.06567084 1.6089258 0 ;
	setAttr ".rs" 35770;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.13260529170302784 1.5894788721746134 -0.060363891643251441 ;
	setAttr ".cbx" -type "double3" 0.0012636092107263617 1.6283727024781791 0.060363891643251441 ;
createNode polyTweak -n "polyTweak5";
	rename -uid "85E3FCF7-4A0A-6BC3-DE6C-AF830BFE26F1";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk[31:37]" -type "float3"  -0.1247306 1.68531525 -1.3877788e-17
		 -0.11958221 1.72148895 -1.3877788e-17 -0.1221564 1.70340216 0 -0.11700793 1.73957598
		 0 -0.11958219 1.72148907 -1.3877788e-17 -0.12473059 1.68531537 -1.3877788e-17 -0.12730488
		 1.66722834 0;
createNode polyTweak -n "polyTweak6";
	rename -uid "8E62A2B6-4A60-E0E7-209B-8094DBFDE92F";
	setAttr ".uopa" yes;
	setAttr -s 7 ".tk[37:43]" -type "float3"  0.41490966 2.082775116 0 0.41490966
		 2.082775116 0 0.41490966 2.082775116 0 0.41490966 2.082775116 0 0.41490966 2.082775116
		 0 0.41490966 2.082775116 0 0.41490966 2.082775116 0;
createNode polySplit -n "polySplit1";
	rename -uid "847EFEE0-4A68-EBE0-212C-0294F460FD88";
	setAttr -s 7 ".e[0:6]"  0.69999999 0.69999999 0.69999999 0.69999999
		 0.69999999 0.69999999 0.69999999;
	setAttr -s 7 ".d[0:6]"  -2147483636 -2147483635 -2147483634 -2147483633 -2147483632 -2147483631 
		-2147483636;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace6";
	rename -uid "7877F955-4899-6506-AD03-5195D20DA506";
	setAttr ".ics" -type "componentList" 1 "f[0:5]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.71954799 0 ;
	setAttr ".rs" 37123;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.72461984132762747 0.59325356169395049 -0.62753926538782401 ;
	setAttr ".cbx" -type "double3" 0.72461984132762747 0.84584245642984013 0.62753926538782401 ;
createNode polyTweak -n "polyTweak7";
	rename -uid "4E1B7F7A-479A-44C9-B7F2-5BA39239C039";
	setAttr ".uopa" yes;
	setAttr -s 16 ".tk";
	setAttr ".tk[50]" -type "float3" 0.14935742 -0.056432724 -0.25869441 ;
	setAttr ".tk[51]" -type "float3" -0.14935727 -0.056432724 -0.25869444 ;
	setAttr ".tk[52]" -type "float3" -0.16189262 0.056432724 -0.28040618 ;
	setAttr ".tk[53]" -type "float3" 0.1618927 0.056432724 -0.28040612 ;
	setAttr ".tk[54]" -type "float3" -0.29871455 -0.056432724 -4.2768573e-08 ;
	setAttr ".tk[55]" -type "float3" -0.32378528 0.056432724 -4.575724e-08 ;
	setAttr ".tk[56]" -type "float3" -0.14935742 -0.056432724 0.25869441 ;
	setAttr ".tk[57]" -type "float3" -0.1618927 0.056432724 0.28040612 ;
	setAttr ".tk[58]" -type "float3" 0.14935727 -0.056432724 0.25869441 ;
	setAttr ".tk[59]" -type "float3" 0.16189264 0.056432724 0.28040618 ;
	setAttr ".tk[60]" -type "float3" 0.29871455 -0.056432724 1.7433749e-09 ;
	setAttr ".tk[61]" -type "float3" 0.32378528 0.056432724 2.4905353e-09 ;
createNode polySplit -n "polySplit2";
	rename -uid "5DEFC0B2-4811-9D6C-2BC4-F8830EA1AD98";
	setAttr -s 7 ".e[0:6]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 7 ".d[0:6]"  -2147483576 -2147483575 -2147483571 -2147483568 -2147483565 -2147483562 
		-2147483576;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit3";
	rename -uid "579C5498-41B9-2AC2-2830-0FBF57871433";
	setAttr -s 7 ".e[0:6]"  0.89999998 0.89999998 0.89999998 0.89999998
		 0.89999998 0.89999998 0.89999998;
	setAttr -s 7 ".d[0:6]"  -2147483576 -2147483575 -2147483571 -2147483568 -2147483565 -2147483562 
		-2147483576;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit4";
	rename -uid "5FA44EB5-453E-193E-F565-F1B13FDC66D7";
	setAttr -s 7 ".e[0:6]"  0.69999999 0.69999999 0.69999999 0.69999999
		 0.69999999 0.69999999 0.69999999;
	setAttr -s 7 ".d[0:6]"  -2147483522 -2147483517 -2147483518 -2147483519 -2147483520 -2147483521 
		-2147483522;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit5";
	rename -uid "2D77D36F-4E7E-C742-6C9E-0BBC5D62DD98";
	setAttr -s 7 ".e[0:6]"  0.2 0.2 0.2 0.2 0.2 0.2 0.2;
	setAttr -s 7 ".d[0:6]"  -2147483498 -2147483497 -2147483496 -2147483495 -2147483494 -2147483493 
		-2147483498;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit6";
	rename -uid "DFBD69F4-4294-46AB-9A29-14B46FA18DD9";
	setAttr -s 7 ".e[0:6]"  0.80000001 0.80000001 0.80000001 0.80000001
		 0.80000001 0.80000001 0.80000001;
	setAttr -s 7 ".d[0:6]"  -2147483588 -2147483587 -2147483585 -2147483583 -2147483581 -2147483579 
		-2147483588;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit7";
	rename -uid "CACD2141-4217-FDF5-2A67-6AA3D581FD6A";
	setAttr -s 7 ".e[0:6]"  0.89999998 0.89999998 0.89999998 0.89999998
		 0.89999998 0.89999998 0.89999998;
	setAttr -s 7 ".d[0:6]"  -2147483588 -2147483587 -2147483585 -2147483583 -2147483581 -2147483579 
		-2147483588;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace7";
	rename -uid "4B6C8C95-43BB-EE13-4D2E-6095AA4538C0";
	setAttr ".ics" -type "componentList" 1 "f[70]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.090480633 2.1261945 0.030181946 ;
	setAttr ".rs" 53859;
	setAttr ".lt" -type "double3" -5.5511151231257827e-17 1.6653345369377348e-16 0.95592134870764078 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.068170682723064702 2.0933406457140356 5.3614679622209602e-10 ;
	setAttr ".cbx" -type "double3" 0.112790576213393 2.1590483887582894 0.060363891643251441 ;
createNode polyTweak -n "polyTweak8";
	rename -uid "9C1151E6-4724-4BCC-0ED2-588DDDA13A5E";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[98]" -type "float3" 0.032871298 0.034080043 -0.044470411 ;
	setAttr ".tk[99]" -type "float3" -0.016438747 0.048406344 0.044469856 ;
	setAttr ".tk[100]" -type "float3" -0.032871261 -0.034080043 0.044469856 ;
	setAttr ".tk[101]" -type "float3" 0.016438644 -0.048406344 -0.044470411 ;
createNode polySplit -n "polySplit8";
	rename -uid "84CB340E-4F60-49D2-BB44-54B9A5F53AB0";
	setAttr -s 5 ".e[0:4]"  0.1 0.1 0.1 0.1 0.1;
	setAttr -s 5 ".d[0:4]"  -2147483450 -2147483449 -2147483447 -2147483445 -2147483450;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit9";
	rename -uid "744156DD-43D3-C6E1-FC1F-07B97FFB072D";
	setAttr -s 5 ".e[0:4]"  0.1 0.1 0.1 0.1 0.1;
	setAttr -s 5 ".d[0:4]"  -2147483442 -2147483439 -2147483440 -2147483441 -2147483442;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak9";
	rename -uid "0AB76EB1-4683-9E69-A8AE-C8AE8FDC1944";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[106:109]" -type "float3"  -0.16728643 0 0.28522235 -0.14199451
		 0 0.24209946 0.16728473 0 -0.28522062 0.14199457 0 -0.24210031;
createNode polySplit -n "polySplit10";
	rename -uid "D575F228-4B7C-4179-69F5-E5858FBAB9EE";
	setAttr -s 5 ".e[0:4]"  0.40000001 0.40000001 0.40000001 0.40000001
		 0.40000001;
	setAttr -s 5 ".d[0:4]"  -2147483434 -2147483433 -2147483432 -2147483431 -2147483434;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace8";
	rename -uid "61CE57AF-4D9E-D52C-313F-F092C5E712FC";
	setAttr ".ics" -type "componentList" 1 "f[81]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.077069953 2.5920448 0.030181926 ;
	setAttr ".rs" 37335;
	setAttr ".lt" -type "double3" -1.8735013540549517e-16 6.7654215563095477e-17 0.094967982108801377 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.056990551400424382 2.5703876093020046 -9.850313639170254e-09 ;
	setAttr ".cbx" -type "double3" 0.097149356757889743 2.6137021252161858 0.060363859600009846 ;
createNode polyTweak -n "polyTweak10";
	rename -uid "11983A4D-421A-E426-6719-ACA3CC65F917";
	setAttr ".uopa" yes;
	setAttr -s 6 ".tk";
	setAttr ".tk[98]" -type "float3" 0 -0.45320472 0 ;
	setAttr ".tk[99]" -type "float3" 0 -0.45320472 0 ;
	setAttr ".tk[100]" -type "float3" 0 -0.45320472 0 ;
	setAttr ".tk[101]" -type "float3" 0 -0.45320472 0 ;
createNode polyExtrudeFace -n "polyExtrudeFace9";
	rename -uid "A03FF8C9-414E-0B06-AFD7-AF80F9441FBC";
	setAttr ".ics" -type "componentList" 1 "f[81]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.0036645287 2.6081281 0.077533774 ;
	setAttr ".rs" 44007;
	setAttr ".lt" -type "double3" -2.2204460492503131e-16 1.8041124150158794e-16 0.20972819594034336 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.023743929871457643 2.5864707531239821 0.047351836182339312 ;
	setAttr ".cbx" -type "double3" 0.016414872481953821 2.6297852690381642 0.10771571180396995 ;
createNode polyExtrudeFace -n "polyExtrudeFace10";
	rename -uid "FA334A37-4CCB-1609-B0F4-3BA59E56A313";
	setAttr ".ics" -type "componentList" 1 "f[81]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.085040286 2.5551095 0.12526177 ;
	setAttr ".rs" 32886;
	setAttr ".lt" -type "double3" 3.3306690738754696e-16 -0.29448993789764288 0.46460994530355926 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.17863399034256541 2.5111695198917516 -0.043241905928724213 ;
	setAttr ".cbx" -type "double3" 0.0085534146306261091 2.5990492635260978 0.29376545352752909 ;
createNode polyTweak -n "polyTweak11";
	rename -uid "05BF6A43-47D8-8F58-262F-3A9875FAA9C1";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[118:121]" -type "float3"  0.32293355 -0.20613879 0.15155861
		 0.043535739 -0.12496132 -0.35238338 0.31702825 -0.20441908 0.14090714 0.03763029
		 -0.1232416 -0.36303467;
createNode polyExtrudeFace -n "polyExtrudeFace11";
	rename -uid "EF54CF35-4332-BCC9-B866-2985547B5969";
	setAttr ".ics" -type "componentList" 1 "f[81]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.24006794 2.4137213 0.18645577 ;
	setAttr ".rs" 51003;
	setAttr ".lt" -type "double3" 2.9837243786801082e-16 8.3266726846886741e-17 0.52794586219550232 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.30404553425318859 2.3840821785321289 0.083308006182846492 ;
	setAttr ".cbx" -type "double3" -0.17609034975979462 2.4433606374095493 0.28960354913604491 ;
createNode polyTweak -n "polyTweak12";
	rename -uid "2FA30244-401C-EEC3-2C08-0894CF33479E";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[122]" -type "float3" 0.3977879 0.13594079 -0.63204211 ;
	setAttr ".tk[123]" -type "float3" 0.53623331 0.095716953 -0.38233113 ;
	setAttr ".tk[124]" -type "float3" 0.35643825 0.12296271 -0.60416961 ;
	setAttr ".tk[125]" -type "float3" 0.49488372 0.082738638 -0.35445911 ;
createNode polyExtrudeFace -n "polyExtrudeFace12";
	rename -uid "BABFACE2-4FDC-B255-FA99-F49C5D18AE47";
	setAttr ".ics" -type "componentList" 1 "f[90]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.049854476 1.3895365 -0.060363874 ;
	setAttr ".rs" 41434;
	setAttr ".lt" -type "double3" -9.9723107939269902e-18 1.0274924357194767e-16 0.10755397085350075 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.086280697759780353 1.3455168832439508 -0.060363891643251441 ;
	setAttr ".cbx" -type "double3" -0.013428253109789909 1.4335560740484801 -0.060363859600009846 ;
createNode polyTweak -n "polyTweak13";
	rename -uid "1CE4C699-43AC-B5CA-CD57-589333C844A9";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[126]" -type "float3" 0.15050995 -0.30797935 -0.24288541 ;
	setAttr ".tk[127]" -type "float3" 0.33117431 -0.36047125 0.082970709 ;
	setAttr ".tk[128]" -type "float3" 0.1794638 -0.35026073 -0.25656652 ;
	setAttr ".tk[129]" -type "float3" 0.36012912 -0.40275335 0.069290102 ;
createNode polyExtrudeFace -n "polyExtrudeFace13";
	rename -uid "8E23140D-4FEF-4602-F213-F4B5933DB527";
	setAttr ".ics" -type "componentList" 1 "f[90]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.049854428 1.3895365 -0.16791786 ;
	setAttr ".rs" 47544;
	setAttr ".lt" -type "double3" -6.9388939039072284e-18 1.2199486983164382e-16 0.15710758320700818 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.086280657705728347 1.3455168832439508 -0.16791786518526444 ;
	setAttr ".cbx" -type "double3" -0.013428201039522315 1.4335560740484801 -0.16791784916364366 ;
createNode polyExtrudeFace -n "polyExtrudeFace14";
	rename -uid "DF3DFC45-4B50-8652-C10F-7DA564715C1C";
	setAttr ".ics" -type "componentList" 1 "f[90]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.049391057 1.389441 -0.32502544 ;
	setAttr ".rs" 54360;
	setAttr ".lt" -type "double3" 0 0.17606823709392644 0.43619376770423679 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.23195054777507576 1.3152025027048078 -0.32502546216941824 ;
	setAttr ".cbx" -type "double3" 0.13316843565246073 1.4636796050406757 -0.32502543012617663 ;
createNode polyTweak -n "polyTweak14";
	rename -uid "FB51FFD0-4A05-BF5C-A3A1-46B8D705BACD";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[134:137]" -type "float3"  0.27268887 -0.056388736 0
		 -0.14885038 0.03078115 0 -0.27096531 0.056033731 0 0.15117273 -0.031260014 0;
createNode polyExtrudeFace -n "polyExtrudeFace15";
	rename -uid "0FA9B3E1-4484-66F8-4C24-74AF52A89089";
	setAttr ".ics" -type "componentList" 1 "f[90]";
	setAttr ".ix" -type "matrix" 0.53759638560006306 0 0 0 0 0.53759638560006306 0 0
		 0 0 0.53759638560006306 0 0 0.5414758168526157 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.040886048 1.2546501 -0.55719322 ;
	setAttr ".rs" 34395;
	setAttr ".lt" -type "double3" 0 0.29903493822185717 0.39561883593180985 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.18696276582798119 1.1879558423479688 -0.55719319903603315 ;
	setAttr ".cbx" -type "double3" 0.10519067232294578 1.3213444230810061 -0.55719319903603315 ;
createNode polyTweak -n "polyTweak15";
	rename -uid "D4475916-4B3F-34CA-AA0B-C89F35AD582B";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[138:141]" -type "float3"  -0.052042499 0.09081471 0.37951529
		 0.053196743 0.069051862 0.37951529 0.083683014 0.062747836 0.37951529 -0.021705575
		 0.084541559 0.37951529;
createNode polyTweak -n "polyTweak16";
	rename -uid "122794F1-4D6A-3C3B-056F-A5885B5AF1A1";
	setAttr ".uopa" yes;
	setAttr -s 6 ".tk";
	setAttr ".tk[142]" -type "float3" -0.2148179 0.079638839 0 ;
	setAttr ".tk[143]" -type "float3" 0.12876573 0.0085885525 0 ;
	setAttr ".tk[144]" -type "float3" 0.21418226 -0.080256283 0 ;
	setAttr ".tk[145]" -type "float3" -0.12957975 -0.0076066256 0 ;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "6677A115-4120-99FD-738E-B2B2ACEFE0FD";
	setAttr ".dc" -type "componentList" 2 "e[181:185]" "e[193:197]";
createNode deleteComponent -n "deleteComponent2";
	rename -uid "B646CB29-436B-60CB-6ABD-1DAF977621AF";
	setAttr ".dc" -type "componentList" 2 "vtx[88:91]" "vtx[94:97]";
createNode deleteComponent -n "deleteComponent3";
	rename -uid "BE92109A-435B-879B-83A7-B99A3F7D3092";
	setAttr ".dc" -type "componentList" 1 "e[6:11]";
createNode deleteComponent -n "deleteComponent4";
	rename -uid "14E24354-459A-F32F-3C70-E69A881A7AE4";
	setAttr ".dc" -type "componentList" 1 "vtx[6:11]";
createNode deleteComponent -n "deleteComponent5";
	rename -uid "8160C351-4090-C3E4-588F-139637CE61D0";
	setAttr ".dc" -type "componentList" 5 "e[36:37]" "e[39]" "e[41]" "e[43]" "e[45]";
createNode deleteComponent -n "deleteComponent6";
	rename -uid "0048B057-4B2C-611F-73DE-B09E076DA553";
	setAttr ".dc" -type "componentList" 1 "e[12:17]";
createNode polyTweak -n "polyTweak17";
	rename -uid "132F8926-4963-CBE0-C4E9-56B637960CFF";
	setAttr ".uopa" yes;
	setAttr -s 21 ".tk";
	setAttr ".tk[43]" -type "float3" 0 0.13166434 0 ;
	setAttr ".tk[44]" -type "float3" 0 0.13166434 0 ;
	setAttr ".tk[47]" -type "float3" 0 0.13166434 -8.5661611e-10 ;
	setAttr ".tk[49]" -type "float3" 0 0.13166434 0 ;
	setAttr ".tk[51]" -type "float3" 0 0.13166434 0 ;
	setAttr ".tk[53]" -type "float3" 0 0.13166434 -8.5660723e-10 ;
createNode deleteComponent -n "deleteComponent7";
	rename -uid "BC36883B-4375-AB32-44DC-0F87ED66BD51";
	setAttr ".dc" -type "componentList" 4 "e[104:107]" "e[109]" "e[116:119]" "e[121]";
createNode deleteComponent -n "deleteComponent8";
	rename -uid "A715EA96-4E8B-08C8-B50E-F08A4B39429D";
	setAttr ".dc" -type "componentList" 2 "vtx[55:58]" "vtx[61:64]";
createNode deleteComponent -n "deleteComponent9";
	rename -uid "8CB40BFA-4CB9-3777-D548-DA81CCDBF48D";
	setAttr ".dc" -type "componentList" 5 "e[45:46]" "e[48]" "e[50]" "e[53]" "e[56]";
createNode deleteComponent -n "deleteComponent10";
	rename -uid "23970685-4ECC-2914-0F33-7F89E6D9DE49";
	setAttr ".dc" -type "componentList" 4 "e[104:106]" "e[108:109]" "e[116:118]" "e[120:121]";
createNode deleteComponent -n "deleteComponent11";
	rename -uid "7DA4DF0A-4686-18EE-15D3-4DB2F1A50C99";
	setAttr ".dc" -type "componentList" 3 "vtx[58:60]" "vtx[63:66]" "vtx[69]";
createNode script -n "uiConfigurationScriptNode";
	rename -uid "1EB7BB4C-468A-25F5-17FB-869D3F3FEA19";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $nodeEditorPanelVisible = stringArrayContains(\"nodeEditorPanel1\", `getPanel -vis`);\n\tint    $nodeEditorWorkspaceControlOpen = (`workspaceControl -exists nodeEditorPanel1Window` && `workspaceControl -q -visible nodeEditorPanel1Window`);\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\n\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n"
		+ "            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n"
		+ "            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n"
		+ "            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1314\n            -height 702\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n"
		+ "            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n            -expandAttribute 0\n            $editorName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n"
		+ "            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n"
		+ "            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n"
		+ "                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n"
		+ "                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 1\n                -autoFitTime 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n"
		+ "                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -showCurveNames 0\n                -showActiveCurveNames 0\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                -valueLinesToggle 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n"
		+ "            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n"
		+ "                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n"
		+ "                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n"
		+ "                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif ($nodeEditorPanelVisible || $nodeEditorWorkspaceControlOpen) {\n"
		+ "\t\tif (\"\" == $panelName) {\n\t\t\tif ($useSceneConfig) {\n\t\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n"
		+ "                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\t}\n\t\t} else {\n\t\t\t$label = `panel -q -label $panelName`;\n\t\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n"
		+ "                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\tif (!$useSceneConfig) {\n\t\t\t\tpanel -e -l $label $panelName;\n\t\t\t}\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1314\\n    -height 702\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1314\\n    -height 702\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "9C4AE1E4-49F4-AFF0-0F9C-D29DB6EF5012";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "deleteComponent11.og" "prpPlantShape.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polyTweak1.out" "polyExtrudeFace1.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace1.mp";
connectAttr "polyCylinder1.out" "polyTweak1.ip";
connectAttr "polyTweak2.out" "polyExtrudeFace2.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace2.mp";
connectAttr "polyExtrudeFace1.out" "polyTweak2.ip";
connectAttr "polyTweak3.out" "polyExtrudeFace3.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace3.mp";
connectAttr "polyExtrudeFace2.out" "polyTweak3.ip";
connectAttr "polyTweak4.out" "polyExtrudeFace4.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace4.mp";
connectAttr "polyExtrudeFace3.out" "polyTweak4.ip";
connectAttr "polyTweak5.out" "polyExtrudeFace5.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace5.mp";
connectAttr "polyExtrudeFace4.out" "polyTweak5.ip";
connectAttr "polyExtrudeFace5.out" "polyTweak6.ip";
connectAttr "polyTweak6.out" "polySplit1.ip";
connectAttr "polySplit1.out" "polyExtrudeFace6.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace6.mp";
connectAttr "polyExtrudeFace6.out" "polyTweak7.ip";
connectAttr "polyTweak7.out" "polySplit2.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polySplit3.out" "polySplit4.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polySplit5.out" "polySplit6.ip";
connectAttr "polySplit6.out" "polySplit7.ip";
connectAttr "polySplit7.out" "polyExtrudeFace7.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace7.mp";
connectAttr "polyExtrudeFace7.out" "polyTweak8.ip";
connectAttr "polyTweak8.out" "polySplit8.ip";
connectAttr "polySplit8.out" "polySplit9.ip";
connectAttr "polySplit9.out" "polyTweak9.ip";
connectAttr "polyTweak9.out" "polySplit10.ip";
connectAttr "polyTweak10.out" "polyExtrudeFace8.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace8.mp";
connectAttr "polySplit10.out" "polyTweak10.ip";
connectAttr "polyExtrudeFace8.out" "polyExtrudeFace9.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace9.mp";
connectAttr "polyTweak11.out" "polyExtrudeFace10.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace10.mp";
connectAttr "polyExtrudeFace9.out" "polyTweak11.ip";
connectAttr "polyTweak12.out" "polyExtrudeFace11.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace11.mp";
connectAttr "polyExtrudeFace10.out" "polyTweak12.ip";
connectAttr "polyTweak13.out" "polyExtrudeFace12.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace12.mp";
connectAttr "polyExtrudeFace11.out" "polyTweak13.ip";
connectAttr "polyExtrudeFace12.out" "polyExtrudeFace13.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace13.mp";
connectAttr "polyTweak14.out" "polyExtrudeFace14.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace14.mp";
connectAttr "polyExtrudeFace13.out" "polyTweak14.ip";
connectAttr "polyTweak15.out" "polyExtrudeFace15.ip";
connectAttr "prpPlantShape.wm" "polyExtrudeFace15.mp";
connectAttr "polyExtrudeFace14.out" "polyTweak15.ip";
connectAttr "polyExtrudeFace15.out" "polyTweak16.ip";
connectAttr "polyTweak16.out" "deleteComponent1.ig";
connectAttr "deleteComponent1.og" "deleteComponent2.ig";
connectAttr "deleteComponent2.og" "deleteComponent3.ig";
connectAttr "deleteComponent3.og" "deleteComponent4.ig";
connectAttr "deleteComponent4.og" "deleteComponent5.ig";
connectAttr "deleteComponent5.og" "deleteComponent6.ig";
connectAttr "deleteComponent6.og" "polyTweak17.ip";
connectAttr "polyTweak17.out" "deleteComponent7.ig";
connectAttr "deleteComponent7.og" "deleteComponent8.ig";
connectAttr "deleteComponent8.og" "deleteComponent9.ig";
connectAttr "deleteComponent9.og" "deleteComponent10.ig";
connectAttr "deleteComponent10.og" "deleteComponent11.ig";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "prpPlantShape.iog" ":initialShadingGroup.dsm" -na;
// End of prpPlant.ma

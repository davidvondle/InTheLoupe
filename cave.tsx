<?xml version="1.0" encoding="UTF-8"?>
<tileset version="1.2" tiledversion="1.2.0" name="cave" tilewidth="16" tileheight="16" tilecount="91" columns="13">
 <image source="GameOfCaves.png" width="208" height="112"/>
 <terraintypes>
  <terrain name="wall" tile="2556"/>
  <terrain name="inner wall" tile="10"/>
 </terraintypes>
 <tile id="0" terrain=",,,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="16" y="1">
    <polygon points="0,0 -3,0 -5,2 -8,3 -11,4 -15,8 -15,15 -16,15 -16,-1 0,-1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="1" terrain=",,0,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="1">
    <polygon points="0,0 16,0 16,-1 0,-1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="2" terrain=",,0,">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="1">
    <polygon points="0,0 3,0 5,2 8,3 11,4 15,8 15,9 15,15 16,15 16,-1 0,-1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="5" terrain=",,,1"/>
 <tile id="6" terrain=",,1,1"/>
 <tile id="7" terrain=",,1,"/>
 <tile id="8" terrain="1,1,1,"/>
 <tile id="9" terrain="1,1,,1"/>
 <tile id="10">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="1" y="0">
    <polygon points="0,0 0,15 2,15 2,16 -1,16 -1,0"/>
   </object>
   <object id="2" type="CaveWall" x="10" y="15">
    <polygon points="0,0 6,0 6,1 0,1"/>
   </object>
   <object id="3" type="CaveEntrance" x="5" y="16">
    <polygon points="0,0 0,-4 3,-4 3,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="11">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 3,0 3,1 0,1"/>
   </object>
   <object id="2" type="CaveWall" x="10" y="15">
    <polygon points="0,0 0,1 6,1 6,0"/>
   </object>
   <object id="3" type="CaveEntrance" x="8" y="12">
    <polygon points="0,0 0,4 -3,4 -3,0 0,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="12">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 3,0 3,1 0,1"/>
   </object>
   <object id="3" type="CaveWall" x="10" y="15">
    <polygon points="0,0 5,0 5,-15 6,-15 6,1 0,1 0,0"/>
   </object>
   <object id="4" type="CaveEntrance" x="8" y="12">
    <polygon points="0,0 0,4 -3,4 -3,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="13" terrain=",0,,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="1" y="0">
    <polygon points="0,0 0,16 -1,16 -1,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="14" terrain="0,0,0,0"/>
 <tile id="15" terrain="0,,0,">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="15" y="0">
    <polygon points="0,0 0,16 1,16 1,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="18" terrain=",1,,1"/>
 <tile id="19" terrain="1,1,1,1"/>
 <tile id="20" terrain="1,,1,"/>
 <tile id="21" terrain="1,,1,1"/>
 <tile id="22" terrain=",1,1,1"/>
 <tile id="23">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="0">
    <polygon points="0,0 0,16 7,16 7,15 1,15 1,0"/>
   </object>
   <object id="2" type="CaveWall" x="14" y="15">
    <polygon points="0,0 0,1 2,1 2,0 0,0"/>
   </object>
   <object id="3" type="CaveEntrance" x="12" y="12">
    <polygon points="0,0 0,4 -3,4 -3,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="24">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 7,0 7,1 0,1"/>
   </object>
   <object id="2" type="CaveEntrance" x="9" y="12">
    <polygon points="0,0 0,4 3,4 3,0"/>
   </object>
   <object id="3" type="CaveWall" x="14" y="15">
    <polygon points="0,0 2,0 2,1 0,1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="25">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 7,0 7,1 0,1"/>
   </object>
   <object id="2" type="CaveWall" x="14" y="15">
    <polygon points="0,0 0,1 2,1 2,-15 1,-15 1,0"/>
   </object>
   <object id="3" type="CaveEntrance" x="9" y="12">
    <polygon points="0,0 0,4 3,4 3,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="26" terrain=",0,,">
  <objectgroup draworder="index">
   <object id="2" type="CaveWall" x="1" y="0">
    <polygon points="0,0 0,7 5,12 7,12 9,13 11,15 15,15 15,16 -1,16 -1,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="27" terrain="0,0,,">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 16,0 16,1 0,1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="28" terrain="0,,,">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 3,0 5,-2 7,-2 8,-3 10,-3 15,-8 15,-15 16,-15 16,1 0,1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="31" terrain=",1,,"/>
 <tile id="32" terrain="1,1,,"/>
 <tile id="33" terrain="1,,,"/>
 <tile id="34">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="0">
    <polygon points="0,0 0,4 16,4 16,0 15,0 15,3 1,3 1,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="46">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="1" y="12">
    <polygon points="0,0 0,3 3,3 3,4 -1,4 -1,-12 0,-12"/>
   </object>
   <object id="2" type="CaveWall" x="16" y="15">
    <polygon points="0,0 -5,0 -5,1 0,1"/>
   </object>
   <object id="3" type="CaveEntrance" x="5.57143" y="12">
    <polygon points="0.428571,0 0.428571,4 3.42857,4 3.42857,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="47">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 4,0 4,1 0,1"/>
   </object>
   <object id="2" type="CaveWall" x="13" y="15">
    <polygon points="-2,0 3,0 3,1 -2,1"/>
   </object>
   <object id="3" type="CaveEntrance" x="5.57143" y="12">
    <polygon points="0.428571,0 0.428571,4 3.42857,4 3.42857,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="48">
  <objectgroup draworder="index">
   <object id="1" x="0" y="15">
    <polygon points="0,0 4,0 4,1 0,1"/>
   </object>
   <object id="3" type="CaveWall" x="13" y="16">
    <polygon points="-2,0 2,0 3,0 3,-16 2,-16 2,-1 -2,-1"/>
   </object>
   <object id="4" type="CaveEntrance" x="5.57143" y="12">
    <polygon points="0.428571,0 0.428571,4 3.42857,4 3.42857,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="60" terrain="0,0,0,">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="16" y="15">
    <polygon points="0,0 -1,0 -1,1 0,1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="61" terrain="0,0,,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="15">
    <polygon points="0,0 1,0 1,1 0,1"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="73" terrain="0,,0,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="15" y="0">
    <polygon points="0,0 0,1 1,1 1,0"/>
   </object>
  </objectgroup>
 </tile>
 <tile id="74" terrain=",0,0,0">
  <objectgroup draworder="index">
   <object id="1" type="CaveWall" x="0" y="1">
    <polygon points="0,0 1,0 1,-1 0,-1"/>
   </object>
  </objectgroup>
 </tile>
</tileset>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public abstract class TMP_Text : MaskableGraphic
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		public virtual string text
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x58BF080", Offset = "0x58BDC80", VA = "0x1858BF080", Slot = "67")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x58C1070", Offset = "0x58BFC70", VA = "0x1858C1070", Slot = "68")]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010B")]
		public ITextPreprocessor textPreprocessor
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x4D6D140", Offset = "0x4D6BD40", VA = "0x184D6D140")]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public bool isRightToLeftText
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x4DA7710", Offset = "0x4DA6310", VA = "0x184DA7710")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x58C04F0", Offset = "0x58BF0F0", VA = "0x1858C04F0")]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010D")]
		public TMP_FontAsset font
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x58C01C0", Offset = "0x58BEDC0", VA = "0x1858C01C0")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010E")]
		public virtual Material fontSharedMaterial
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520", Slot = "69")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x58BFE40", Offset = "0x58BEA40", VA = "0x1858BFE40", Slot = "70")]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		public virtual Material[] fontSharedMaterials
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x58BE6A0", Offset = "0x58BD2A0", VA = "0x1858BE6A0", Slot = "71")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x58BFDA0", Offset = "0x58BE9A0", VA = "0x1858BFDA0", Slot = "72")]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		public Material fontMaterial
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x58BE600", Offset = "0x58BD200", VA = "0x1858BE600")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x58BFC50", Offset = "0x58BE850", VA = "0x1858BFC50")]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000111")]
		public virtual Material[] fontMaterials
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x58BE650", Offset = "0x58BD250", VA = "0x1858BE650", Slot = "73")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x58BFDA0", Offset = "0x58BE9A0", VA = "0x1858BFDA0", Slot = "74")]
			set
			{
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000112")]
		public override Color color
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x58BE460", Offset = "0x58BD060", VA = "0x1858BE460", Slot = "22")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x58BF800", Offset = "0x58BE400", VA = "0x1858BF800", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		public float alpha
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x58BE310", Offset = "0x58BCF10", VA = "0x1858BE310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x58BF5D0", Offset = "0x58BE1D0", VA = "0x1858BF5D0")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		public bool enableVertexGradient
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x58BE4A0", Offset = "0x58BD0A0", VA = "0x1858BE4A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x58BFA00", Offset = "0x58BE600", VA = "0x1858BFA00")]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000115")]
		public VertexGradient colorGradient
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x58BE430", Offset = "0x58BD030", VA = "0x1858BE430")]
			get
			{
				return default(VertexGradient);
			}
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x58BF790", Offset = "0x58BE390", VA = "0x1858BF790")]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000116")]
		public TMP_ColorGradient colorGradientPreset
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x58BF740", Offset = "0x58BE340", VA = "0x1858BF740")]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x58C0EF0", Offset = "0x58BFAF0", VA = "0x1858C0EF0")]
			set
			{
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000118")]
		public bool tintAllSprites
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x58BF170", Offset = "0x58BDD70", VA = "0x1858BF170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x58C1130", Offset = "0x58BFD30", VA = "0x1858C1130")]
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		public TMP_StyleSheet styleSheet
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x58C0F60", Offset = "0x58BFB60", VA = "0x1858C0F60")]
			set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		public TMP_Style textStyle
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x58BF000", Offset = "0x58BDC00", VA = "0x1858BF000")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x58C0FD0", Offset = "0x58BFBD0", VA = "0x1858C0FD0")]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public bool overrideColorTags
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x58BEB40", Offset = "0x58BD740", VA = "0x1858BEB40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x58C0CB0", Offset = "0x58BF8B0", VA = "0x1858C0CB0")]
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		public Color32 faceColor
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x58BE4D0", Offset = "0x58BD0D0", VA = "0x1858BE4D0")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x58BFB50", Offset = "0x58BE750", VA = "0x1858BFB50")]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public Color32 outlineColor
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x58BE970", Offset = "0x58BD570", VA = "0x1858BE970")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x58C0B10", Offset = "0x58BF710", VA = "0x1858C0B10")]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		public float outlineWidth
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x58BEA60", Offset = "0x58BD660", VA = "0x1858BEA60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x58C0BA0", Offset = "0x58BF7A0", VA = "0x1858C0BA0")]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		public float fontSize
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x58BE700", Offset = "0x58BD300", VA = "0x1858BE700")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x58C0030", Offset = "0x58BEC30", VA = "0x1858C0030")]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		public FontWeight fontWeight
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x58BE720", Offset = "0x58BD320", VA = "0x1858BE720")]
			get
			{
				return (FontWeight)0;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x58C0140", Offset = "0x58BED40", VA = "0x1858C0140")]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x17000121")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x58BEB80", Offset = "0x58BD780", VA = "0x1858BEB80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000122")]
		public bool enableAutoSizing
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x58BE470", Offset = "0x58BD070", VA = "0x1858BE470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x58BF8C0", Offset = "0x58BE4C0", VA = "0x1858BF8C0")]
			set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		public float fontSizeMin
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x58BE6F0", Offset = "0x58BD2F0", VA = "0x1858BE6F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x58BFFB0", Offset = "0x58BEBB0", VA = "0x1858BFFB0")]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		public float fontSizeMax
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x58BE6E0", Offset = "0x58BD2E0", VA = "0x1858BE6E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x58BFF30", Offset = "0x58BEB30", VA = "0x1858BFF30")]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000125")]
		public FontStyles fontStyle
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x58BE710", Offset = "0x58BD310", VA = "0x1858BE710")]
			get
			{
				return FontStyles.Normal;
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x58C00C0", Offset = "0x58BECC0", VA = "0x1858C00C0")]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x17000126")]
		public bool isUsingBold
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x58BE7D0", Offset = "0x58BD3D0", VA = "0x1858BE7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00003A80 File Offset: 0x00001C80
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public HorizontalAlignmentOptions horizontalAlignment
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x58BE750", Offset = "0x58BD350", VA = "0x1858BE750")]
			get
			{
				return (HorizontalAlignmentOptions)0;
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x58C0360", Offset = "0x58BEF60", VA = "0x1858C0360")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00003A98 File Offset: 0x00001C98
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public VerticalAlignmentOptions verticalAlignment
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x58BF250", Offset = "0x58BDE50", VA = "0x1858BF250")]
			get
			{
				return (VerticalAlignmentOptions)0;
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x58C1210", Offset = "0x58BFE10", VA = "0x1858C1210")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00003AB0 File Offset: 0x00001CB0
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public TextAlignmentOptions alignment
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x58BE300", Offset = "0x58BCF00", VA = "0x1858BE300")]
			get
			{
				return (TextAlignmentOptions)0;
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x58BF560", Offset = "0x58BE160", VA = "0x1858BF560")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public float characterSpacing
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x58BE410", Offset = "0x58BD010", VA = "0x1858BE410")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x58BF640", Offset = "0x58BE240", VA = "0x1858BF640")]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00003AE0 File Offset: 0x00001CE0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public float wordSpacing
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x58BF270", Offset = "0x58BDE70", VA = "0x1858BF270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x58C12B0", Offset = "0x58BFEB0", VA = "0x1858C12B0")]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public float lineSpacing
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x58BE8C0", Offset = "0x58BD4C0", VA = "0x1858BE8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x58C0720", Offset = "0x58BF320", VA = "0x1858C0720")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		public float lineSpacingAdjustment
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x58BE8B0", Offset = "0x58BD4B0", VA = "0x1858BE8B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x58C06A0", Offset = "0x58BF2A0", VA = "0x1858C06A0")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		public float paragraphSpacing
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x58BEB60", Offset = "0x58BD760", VA = "0x1858BEB60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x58C0D50", Offset = "0x58BF950", VA = "0x1858C0D50")]
			set
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		public float characterWidthAdjustment
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x58BE420", Offset = "0x58BD020", VA = "0x1858BE420")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x58BF6C0", Offset = "0x58BE2C0", VA = "0x1858BF6C0")]
			set
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		public bool enableWordWrapping
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x58BE4B0", Offset = "0x58BD0B0", VA = "0x1858BE4B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x58BFA50", Offset = "0x58BE650", VA = "0x1858BFA50")]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00003B70 File Offset: 0x00001D70
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		public float wordWrappingRatios
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x58BF280", Offset = "0x58BDE80", VA = "0x1858BF280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x58C1330", Offset = "0x58BFF30", VA = "0x1858C1330")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00003B88 File Offset: 0x00001D88
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		public TextOverflowModes overflowMode
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x58BEB30", Offset = "0x58BD730", VA = "0x1858BEB30")]
			get
			{
				return TextOverflowModes.Overflow;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x58C0C30", Offset = "0x58BF830", VA = "0x1858C0C30")]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x17000133")]
		public bool isTextOverflowing
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x58BE7B0", Offset = "0x58BD3B0", VA = "0x1858BE7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x17000134")]
		public int firstOverflowCharacterIndex
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x58BE5C0", Offset = "0x58BD1C0", VA = "0x1858BE5C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		public TMP_Text linkedTextComponent
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x58BE8D0", Offset = "0x58BD4D0", VA = "0x1858BE8D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x58C07A0", Offset = "0x58BF3A0", VA = "0x1858C07A0")]
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x17000136")]
		public bool isTextTruncated
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x58BE7C0", Offset = "0x58BD3C0", VA = "0x1858BE7C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000137")]
		public bool enableKerning
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x58BE490", Offset = "0x58BD090", VA = "0x1858BE490")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x58BF980", Offset = "0x58BE580", VA = "0x1858BF980")]
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00003C00 File Offset: 0x00001E00
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000138")]
		public bool extraPadding
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x58BE4C0", Offset = "0x58BD0C0", VA = "0x1858BE4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x58BFAD0", Offset = "0x58BE6D0", VA = "0x1858BFAD0")]
			set
			{
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000139")]
		public bool richText
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x58BEE70", Offset = "0x58BDA70", VA = "0x1858BEE70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x58C0E70", Offset = "0x58BFA70", VA = "0x1858C0E70")]
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		public bool parseCtrlCharacters
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x58BEB70", Offset = "0x58BD770", VA = "0x1858BEB70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x58C0DD0", Offset = "0x58BF9D0", VA = "0x1858C0DD0")]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public bool isOverlay
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x58BE790", Offset = "0x58BD390", VA = "0x1858BE790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x58C0470", Offset = "0x58BF070", VA = "0x1858C0470")]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00003C60 File Offset: 0x00001E60
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		public bool isOrthographic
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x58BE780", Offset = "0x58BD380", VA = "0x1858BE780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x58C0420", Offset = "0x58BF020", VA = "0x1858C0420")]
			set
			{
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013D")]
		public bool enableCulling
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x58BE480", Offset = "0x58BD080", VA = "0x1858BE480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x58BF930", Offset = "0x58BE530", VA = "0x1858BF930")]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00003C90 File Offset: 0x00001E90
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		public bool ignoreVisibility
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x58BE770", Offset = "0x58BD370", VA = "0x1858BE770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x58C0400", Offset = "0x58BF000", VA = "0x1858C0400")]
			set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00003CA8 File Offset: 0x00001EA8
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013F")]
		public TextureMappingOptions horizontalMapping
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x58BE760", Offset = "0x58BD360", VA = "0x1858BE760")]
			get
			{
				return TextureMappingOptions.Character;
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x58C03B0", Offset = "0x58BEFB0", VA = "0x1858C03B0")]
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000140")]
		public TextureMappingOptions verticalMapping
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x58BF260", Offset = "0x58BDE60", VA = "0x1858BF260")]
			get
			{
				return TextureMappingOptions.Character;
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x58C1260", Offset = "0x58BFE60", VA = "0x1858C1260")]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00003CD8 File Offset: 0x00001ED8
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		public float mappingUvLineOffset
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x58BE8E0", Offset = "0x58BD4E0", VA = "0x1858BE8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x58C08E0", Offset = "0x58BF4E0", VA = "0x1858C08E0")]
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		public TextRenderFlags renderMode
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x58BEE60", Offset = "0x58BDA60", VA = "0x1858BEE60")]
			get
			{
				return TextRenderFlags.DontRender;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x58C0E50", Offset = "0x58BFA50", VA = "0x1858C0E50")]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00003D08 File Offset: 0x00001F08
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public VertexSortingOrder geometrySortingOrder
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x58BE730", Offset = "0x58BD330", VA = "0x1858BE730")]
			get
			{
				return VertexSortingOrder.Normal;
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x58C02D0", Offset = "0x58BEED0", VA = "0x1858C02D0")]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00003D20 File Offset: 0x00001F20
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		public bool isTextObjectScaleStatic
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x58BE7A0", Offset = "0x58BD3A0", VA = "0x1858BE7A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x58C0570", Offset = "0x58BF170", VA = "0x1858C0570")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00003D38 File Offset: 0x00001F38
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public bool vertexBufferAutoSizeReduction
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x58BF240", Offset = "0x58BDE40", VA = "0x1858BF240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x58C11D0", Offset = "0x58BFDD0", VA = "0x1858C11D0")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public int firstVisibleCharacter
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x58BE5D0", Offset = "0x58BD1D0", VA = "0x1858BE5D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x58BFC00", Offset = "0x58BE800", VA = "0x1858BFC00")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public int maxVisibleCharacters
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x58BE910", Offset = "0x58BD510", VA = "0x1858BE910")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x58C0A20", Offset = "0x58BF620", VA = "0x1858C0A20")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public int maxVisibleWords
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x58BE930", Offset = "0x58BD530", VA = "0x1858BE930")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x58C0AC0", Offset = "0x58BF6C0", VA = "0x1858C0AC0")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00003D98 File Offset: 0x00001F98
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public int maxVisibleLines
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x58BE920", Offset = "0x58BD520", VA = "0x1858BE920")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x58C0A70", Offset = "0x58BF670", VA = "0x1858C0A70")]
			set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00003DB0 File Offset: 0x00001FB0
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public bool useMaxVisibleDescender
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x58BF230", Offset = "0x58BDE30", VA = "0x1858BF230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x58C1180", Offset = "0x58BFD80", VA = "0x1858C1180")]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00003DC8 File Offset: 0x00001FC8
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public int pageToDisplay
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x58BEB50", Offset = "0x58BD750", VA = "0x1858BEB50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x58C0D00", Offset = "0x58BF900", VA = "0x1858C0D00")]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00003DE0 File Offset: 0x00001FE0
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public virtual Vector4 margin
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x58BE8F0", Offset = "0x58BD4F0", VA = "0x1858BE8F0", Slot = "75")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x58C0940", Offset = "0x58BF540", VA = "0x1858C0940", Slot = "76")]
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700014D")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x58BEFF0", Offset = "0x58BDBF0", VA = "0x1858BEFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00003DF8 File Offset: 0x00001FF8
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		public bool havePropertiesChanged
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x58BE740", Offset = "0x58BD340", VA = "0x1858BE740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x58C0310", Offset = "0x58BEF10", VA = "0x1858C0310")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00003E10 File Offset: 0x00002010
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public bool isUsingLegacyAnimationComponent
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x58BE7E0", Offset = "0x58BD3E0", VA = "0x1858BE7E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x58C0600", Offset = "0x58BF200", VA = "0x1858C0600")]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000150")]
		public new Transform transform
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x58BF180", Offset = "0x58BDD80", VA = "0x1858BF180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000151")]
		public new RectTransform rectTransform
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x58BEDB0", Offset = "0x58BD9B0", VA = "0x1858BEDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00003E28 File Offset: 0x00002028
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public virtual bool autoSizeTextContainer
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x58BE320", Offset = "0x58BCF20", VA = "0x1858BE320", Slot = "77")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x58BF630", Offset = "0x58BE230", VA = "0x1858BF630", Slot = "78")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000153")]
		public virtual Mesh mesh
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x58773C0", Offset = "0x5875FC0", VA = "0x1858773C0", Slot = "79")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00003E40 File Offset: 0x00002040
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000154")]
		public bool isVolumetricText
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x4437800", Offset = "0x4436400", VA = "0x184437800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x58C0610", Offset = "0x58BF210", VA = "0x1858C0610")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x17000155")]
		public Bounds bounds
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x58BE330", Offset = "0x58BCF30", VA = "0x1858BE330")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x17000156")]
		public Bounds textBounds
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x58BEF90", Offset = "0x58BDB90", VA = "0x1858BEF90")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x58BE030", Offset = "0x58BCC30", VA = "0x1858BE030")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x58BF290", Offset = "0x58BDE90", VA = "0x1858BF290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x58BE1F0", Offset = "0x58BCDF0", VA = "0x1858BE1F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x58BF450", Offset = "0x58BE050", VA = "0x1858BF450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public virtual event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x58BE140", Offset = "0x58BCD40", VA = "0x1858BE140", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x58BF3A0", Offset = "0x58BDFA0", VA = "0x1858BF3A0", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000157")]
		protected TMP_SpriteAnimator spriteAnimator
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x58BEE80", Offset = "0x58BDA80", VA = "0x1858BEE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x17000158")]
		public float flexibleHeight
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x58BE5E0", Offset = "0x58BD1E0", VA = "0x1858BE5E0", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x17000159")]
		public float flexibleWidth
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x58BE5F0", Offset = "0x58BD1F0", VA = "0x1858BE5F0", Slot = "83")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x1700015A")]
		public float minWidth
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x58BE960", Offset = "0x58BD560", VA = "0x1858BE960", Slot = "84")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x1700015B")]
		public float minHeight
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x58BE950", Offset = "0x58BD550", VA = "0x1858BE950", Slot = "85")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x1700015C")]
		public float maxWidth
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x58BE940", Offset = "0x58BD540", VA = "0x1858BE940")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x1700015D")]
		public float maxHeight
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x58BE900", Offset = "0x58BD500", VA = "0x1858BE900")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015E")]
		protected LayoutElement layoutElement
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x58BE7F0", Offset = "0x58BD3F0", VA = "0x1858BE7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x1700015F")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x58BED90", Offset = "0x58BD990", VA = "0x1858BED90", Slot = "86")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x17000160")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x58BED70", Offset = "0x58BD970", VA = "0x1858BED70", Slot = "87")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x17000161")]
		public virtual float renderedWidth
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x58AC060", Offset = "0x58AAC60", VA = "0x1858AC060", Slot = "88")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x17000162")]
		public virtual float renderedHeight
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x58ABF00", Offset = "0x58AAB00", VA = "0x1858ABF00", Slot = "89")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x17000163")]
		public int layoutPriority
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x58BE8A0", Offset = "0x58BD4A0", VA = "0x1858BE8A0", Slot = "90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "91")]
		protected virtual void LoadFontAsset()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "92")]
		protected virtual void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "93")]
		protected virtual Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "94")]
		protected virtual void SetFontBaseMaterial(Material mat)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "95")]
		protected virtual Material[] GetSharedMaterials()
		{
			return null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "96")]
		protected virtual void SetSharedMaterials(Material[] materials)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "97")]
		protected virtual Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x58A77D0", Offset = "0x58A63D0", VA = "0x1858A77D0", Slot = "98")]
		protected virtual Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x58B62B0", Offset = "0x58B4EB0", VA = "0x1858B62B0")]
		protected void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void SetTextSortingOrder(VertexSortingOrder order)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void SetTextSortingOrder(int[] order)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "99")]
		protected virtual void SetFaceColor(Color32 color)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "100")]
		protected virtual void SetOutlineColor(Color32 color)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "101")]
		protected virtual void SetOutlineThickness(float thickness)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "102")]
		protected virtual void SetShaderDepth()
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "103")]
		protected virtual void SetCulling()
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "104")]
		internal virtual void UpdateCulling()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x58AB1D0", Offset = "0x58A9DD0", VA = "0x1858AB1D0", Slot = "105")]
		protected virtual float GetPaddingForMaterial()
		{
			return 0f;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x58AB320", Offset = "0x58A9F20", VA = "0x1858AB320", Slot = "106")]
		protected virtual float GetPaddingForMaterial(Material mat)
		{
			return 0f;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "107")]
		protected virtual Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "108")]
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "109")]
		public virtual void UpdateGeometry(Mesh mesh, int index)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "110")]
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "111")]
		public virtual void UpdateVertexData()
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "112")]
		public virtual void SetVertices(Vector3[] vertices)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "113")]
		public virtual void UpdateMeshPadding()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x58A7910", Offset = "0x58A6510", VA = "0x1858A7910", Slot = "49")]
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x58A7890", Offset = "0x58A6490", VA = "0x1858A7890", Slot = "51")]
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "114")]
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "115")]
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x58B00C0", Offset = "0x58AECC0", VA = "0x1858B00C0")]
		protected void ParseInputText()
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x58B05E0", Offset = "0x58AF1E0", VA = "0x1858B05E0")]
		private void PopulateTextBackingArray(string sourceText)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x58B03E0", Offset = "0x58AEFE0", VA = "0x1858B03E0")]
		private void PopulateTextBackingArray(string sourceText, int start, int length)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x58B02D0", Offset = "0x58AEED0", VA = "0x1858B02D0")]
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x58B04E0", Offset = "0x58AF0E0", VA = "0x1858B04E0")]
		private void PopulateTextBackingArray(char[] sourceText, int start, int length)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x58B06C0", Offset = "0x58AF2C0", VA = "0x1858B06C0")]
		private void PopulateTextProcessingArray()
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x58B5950", Offset = "0x58B4550", VA = "0x1858B5950")]
		private void SetTextInternal(string sourceText)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x58B5DB0", Offset = "0x58B49B0", VA = "0x1858B5DB0")]
		public void SetText(string sourceText, bool syncTextInputBox = true)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x58B60E0", Offset = "0x58B4CE0", VA = "0x1858B60E0")]
		public void SetText(string sourceText, float arg0)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x58B5A50", Offset = "0x58B4650", VA = "0x1858B5A50")]
		public void SetText(string sourceText, float arg0, float arg1)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x58B6040", Offset = "0x58B4C40", VA = "0x1858B6040")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x58B6090", Offset = "0x58B4C90", VA = "0x1858B6090")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x58B5FE0", Offset = "0x58B4BE0", VA = "0x1858B5FE0")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x58B5F10", Offset = "0x58B4B10", VA = "0x1858B5F10")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x58B5F70", Offset = "0x58B4B70", VA = "0x1858B5F70")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x58B5AE0", Offset = "0x58B46E0", VA = "0x1858B5AE0")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x58B5A90", Offset = "0x58B4690", VA = "0x1858B5A90")]
		public void SetText(StringBuilder sourceText)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x58B6130", Offset = "0x58B4D30", VA = "0x1858B6130")]
		private void SetText(StringBuilder sourceText, int start, int length)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x58B5920", Offset = "0x58B4520", VA = "0x1858B5920")]
		public void SetText(char[] sourceText)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x58B6120", Offset = "0x58B4D20", VA = "0x1858B6120")]
		public void SetText(char[] sourceText, int start, int length)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x58B5920", Offset = "0x58B4520", VA = "0x1858B5920")]
		public void SetCharArray(char[] sourceText)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x58B57A0", Offset = "0x58B43A0", VA = "0x1858B57A0")]
		public void SetCharArray(char[] sourceText, int start, int length)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x58AC2B0", Offset = "0x58AAEB0", VA = "0x1858AC2B0")]
		private TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x58B20F0", Offset = "0x58B0CF0", VA = "0x1858B20F0")]
		private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x58B29A0", Offset = "0x58B15A0", VA = "0x1858B29A0")]
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x58B1520", Offset = "0x58B0120", VA = "0x1858B1520")]
		private void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x58B1D10", Offset = "0x58B0910", VA = "0x1858B1D10")]
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x58AF330", Offset = "0x58ADF30", VA = "0x1858AF330")]
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x58AE2C0", Offset = "0x58ACEC0", VA = "0x1858AE2C0")]
		private void InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x58AB050", Offset = "0x58A9C50", VA = "0x1858AB050")]
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex)
		{
			return 0;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x58AB110", Offset = "0x58A9D10", VA = "0x1858AB110")]
		private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex)
		{
			return 0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x58AC0E0", Offset = "0x58AACE0", VA = "0x1858AC0E0")]
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex)
		{
			return 0;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x58AC1C0", Offset = "0x58AADC0", VA = "0x1858AC1C0")]
		private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex)
		{
			return 0;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000584")]
		private void ResizeInternalArray<T>(ref T[] array)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		private void ResizeInternalArray<T>(ref T[] array, int size)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x58A3E10", Offset = "0x58A2A10", VA = "0x1858A3E10")]
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x58A4290", Offset = "0x58A2E90", VA = "0x1858A4290")]
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x58AFB10", Offset = "0x58AE710", VA = "0x1858AFB10")]
		private string InternalTextBackingArrayToString()
		{
			return null;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "116")]
		internal virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars)
		{
			return 0;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x58ABC10", Offset = "0x58AA810", VA = "0x1858ABC10")]
		public Vector2 GetPreferredValues()
		{
			return default(Vector2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x58AB830", Offset = "0x58AA430", VA = "0x1858AB830")]
		public Vector2 GetPreferredValues(float width, float height)
		{
			return default(Vector2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x58AB8B0", Offset = "0x58AA4B0", VA = "0x1858AB8B0")]
		public Vector2 GetPreferredValues(string text)
		{
			return default(Vector2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x58ABA80", Offset = "0x58AA680", VA = "0x1858ABA80")]
		public Vector2 GetPreferredValues(string text, float width, float height)
		{
			return default(Vector2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x58ABC70", Offset = "0x58AA870", VA = "0x1858ABC70")]
		protected float GetPreferredWidth()
		{
			return 0f;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x58ABE00", Offset = "0x58AAA00", VA = "0x1858ABE00")]
		private float GetPreferredWidth(Vector2 margin)
		{
			return 0f;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x58AB620", Offset = "0x58AA220", VA = "0x1858AB620")]
		protected float GetPreferredHeight()
		{
			return 0f;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x58AB530", Offset = "0x58AA130", VA = "0x1858AB530")]
		private float GetPreferredHeight(Vector2 margin)
		{
			return 0f;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x58ABFB0", Offset = "0x58AABB0", VA = "0x1858ABFB0")]
		public Vector2 GetRenderedValues()
		{
			return default(Vector2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x58ABF50", Offset = "0x58AAB50", VA = "0x1858ABF50")]
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			return default(Vector2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x58AC060", Offset = "0x58AAC60", VA = "0x1858AC060")]
		private float GetRenderedWidth()
		{
			return 0f;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x58AC010", Offset = "0x58AAC10", VA = "0x1858AC010")]
		protected float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			return 0f;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x58ABF00", Offset = "0x58AAB00", VA = "0x1858ABF00")]
		private float GetRenderedHeight()
		{
			return 0f;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x58ABEB0", Offset = "0x58AAAB0", VA = "0x1858ABEB0")]
		protected float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			return 0f;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x58A4860", Offset = "0x58A3460", VA = "0x1858A4860", Slot = "117")]
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			return default(Vector2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x15A87A0", Offset = "0x15A73A0", VA = "0x1815A87A0", Slot = "118")]
		protected virtual Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x58AACF0", Offset = "0x58A98F0", VA = "0x1858AACF0", Slot = "119")]
		internal virtual Rect GetCanvasSpaceClippingRect()
		{
			return default(Rect);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x58AC6E0", Offset = "0x58AB2E0", VA = "0x1858AC6E0")]
		protected Bounds GetTextBounds()
		{
			return default(Bounds);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x58AC3A0", Offset = "0x58AAFA0", VA = "0x1858AC3A0")]
		protected Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			return default(Bounds);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x58A43E0", Offset = "0x58A2FE0", VA = "0x1858A43E0")]
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x58B2EA0", Offset = "0x58B1AA0", VA = "0x1858B2EA0")]
		protected void ResizeLineExtents(int size)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "120")]
		public virtual TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "121")]
		public virtual void ComputeMarginSize()
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x58AEA90", Offset = "0x58AD690", VA = "0x1858AEA90")]
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x58B52B0", Offset = "0x58B3EB0", VA = "0x1858B52B0")]
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x58B30E0", Offset = "0x58B1CE0", VA = "0x1858B30E0")]
		protected int RestoreWordWrappingState(ref WordWrapState state)
		{
			return 0;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x58B3630", Offset = "0x58B2230", VA = "0x1858B3630", Slot = "122")]
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x58B4900", Offset = "0x58B3500", VA = "0x1858B4900", Slot = "123")]
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x58A8F00", Offset = "0x58A7B00", VA = "0x1858A8F00", Slot = "124")]
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x58A96C0", Offset = "0x58A82C0", VA = "0x1858A96C0", Slot = "125")]
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x58AA340", Offset = "0x58A8F40", VA = "0x1858AA340", Slot = "126")]
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x58A7F50", Offset = "0x58A6B50", VA = "0x1858A7F50", Slot = "127")]
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x58A79C0", Offset = "0x58A65C0", VA = "0x1858A79C0", Slot = "128")]
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x58AFCD0", Offset = "0x58AE8D0", VA = "0x1858AFCD0")]
		protected void LoadDefaultSettings()
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x58AC0B0", Offset = "0x58AACB0", VA = "0x1858AC0B0")]
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x58AAD20", Offset = "0x58A9920", VA = "0x1858AAD20")]
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x58AD7B0", Offset = "0x58AC3B0", VA = "0x1858AD7B0")]
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x58B2E40", Offset = "0x58B1A40", VA = "0x1858B2E40")]
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x58AAFC0", Offset = "0x58A9BC0", VA = "0x1858AAFC0")]
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			return null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x58AC9D0", Offset = "0x58AB5D0", VA = "0x1858AC9D0")]
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "129")]
		protected virtual void SetActiveSubMeshes(bool state)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "130")]
		protected virtual void DestroySubMeshObjects()
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "131")]
		public virtual void ClearMesh()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "132")]
		public virtual void ClearMesh(bool uploadGeometry)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x58AB440", Offset = "0x58AA040", VA = "0x1858AB440", Slot = "133")]
		public virtual string GetParsedText()
		{
			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x58AFBE0", Offset = "0x58AE7E0", VA = "0x1858AFBE0")]
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			return default(bool);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x58B13C0", Offset = "0x58AFFC0", VA = "0x1858B13C0")]
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x58B0080", Offset = "0x58AEC80", VA = "0x1858B0080")]
		protected Vector2 PackUV(float x, float y, float scale)
		{
			return default(Vector2);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x58B0040", Offset = "0x58AEC40", VA = "0x1858B0040")]
		protected float PackUV(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "134")]
		internal virtual void InternalUpdate()
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x58AE1B0", Offset = "0x58ACDB0", VA = "0x1858AE1B0")]
		protected int HexToInt(char hex)
		{
			return 0;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x58ACFE0", Offset = "0x58ABBE0", VA = "0x1858ACFE0")]
		protected int GetUTF16(string text, int i)
		{
			return 0;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x58ACF00", Offset = "0x58ABB00", VA = "0x1858ACF00")]
		protected int GetUTF16(int[] text, int i)
		{
			return 0;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x58ACF00", Offset = "0x58ABB00", VA = "0x1858ACF00")]
		internal int GetUTF16(uint[] text, int i)
		{
			return 0;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x58ACE20", Offset = "0x58ABA20", VA = "0x1858ACE20")]
		protected int GetUTF16(StringBuilder text, int i)
		{
			return 0;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x58AD0C0", Offset = "0x58ABCC0", VA = "0x1858AD0C0")]
		private int GetUTF16(TMP_Text.TextBackingContainer text, int i)
		{
			return 0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x58AD190", Offset = "0x58ABD90", VA = "0x1858AD190")]
		protected int GetUTF32(string text, int i)
		{
			return 0;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x58AD320", Offset = "0x58ABF20", VA = "0x1858AD320")]
		protected int GetUTF32(int[] text, int i)
		{
			return 0;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x58AD320", Offset = "0x58ABF20", VA = "0x1858AD320")]
		internal int GetUTF32(uint[] text, int i)
		{
			return 0;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x58AD620", Offset = "0x58AC220", VA = "0x1858AD620")]
		protected int GetUTF32(StringBuilder text, int i)
		{
			return 0;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x58AD4C0", Offset = "0x58AC0C0", VA = "0x1858AD4C0")]
		private int GetUTF32(TMP_Text.TextBackingContainer text, int i)
		{
			return 0;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x58ADBE0", Offset = "0x58AC7E0", VA = "0x1858ADBE0")]
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			return default(Color32);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x58AD910", Offset = "0x58AC510", VA = "0x1858AD910")]
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			return default(Color32);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x58AAB00", Offset = "0x58A9700", VA = "0x1858AAB00")]
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
		{
			return 0;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x58A77A0", Offset = "0x58A63A0", VA = "0x1858A77A0")]
		protected float ConvertToFloat(char[] chars, int startIndex, int length)
		{
			return 0f;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x58A7620", Offset = "0x58A6220", VA = "0x1858A7620")]
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
		{
			return 0f;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x58B6370", Offset = "0x58B4F70", VA = "0x1858B6370")]
		internal bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex)
		{
			return default(bool);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x58BD4B0", Offset = "0x58BC0B0", VA = "0x1858BD4B0")]
		protected TMP_Text()
		{
		}

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_text;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_IsTextBackingStringDirty;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		protected ITextPreprocessor m_TextPreprocessor;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		protected bool m_isRightToLeft;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected TMP_FontAsset m_fontAsset;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x110")]
		protected TMP_FontAsset m_currentFontAsset;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x118")]
		protected bool m_isSDFShader;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected Material m_sharedMaterial;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x128")]
		protected Material m_currentMaterial;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x0")]
		protected static MaterialReference[] m_materialReferences;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x8")]
		protected static Dictionary<int, int> m_materialReferenceIndexLookup;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x10")]
		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x130")]
		protected int m_currentMaterialIndex;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected Material[] m_fontSharedMaterials;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Material m_fontMaterial;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected Material[] m_fontMaterials;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x150")]
		protected bool m_isMaterialDirty;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		protected Color32 m_fontColor32;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected Color m_fontColor;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x68")]
		protected static Color32 s_colorWhite;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x168")]
		protected Color32 m_underlineColor;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x16C")]
		protected Color32 m_strikethroughColor;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected bool m_enableVertexGradient;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		protected ColorMode m_colorMode;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		protected VertexGradient m_fontColorGradient;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		protected TMP_SpriteAsset m_spriteAsset;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		protected bool m_tintAllSprites;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x1C9")]
		protected bool m_tintSprite;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x1CC")]
		protected Color32 m_spriteColor;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		protected TMP_StyleSheet m_StyleSheet;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x1D8")]
		internal TMP_Style m_TextStyle;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		protected int m_TextStyleHashCode;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		protected bool m_overrideHtmlColors;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		protected Color32 m_faceColor;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x1EC")]
		protected Color32 m_outlineColor;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x1F0")]
		protected float m_outlineWidth;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x1F4")]
		[SerializeField]
		protected float m_fontSize;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x1F8")]
		protected float m_currentFontSize;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x1FC")]
		[SerializeField]
		protected float m_fontSizeBase;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x200")]
		protected TMP_TextProcessingStack<float> m_sizeStack;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		protected FontWeight m_fontWeight;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x224")]
		protected FontWeight m_FontWeightInternal;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x228")]
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		protected bool m_enableAutoSizing;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x24C")]
		protected float m_maxFontSize;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x250")]
		protected float m_minFontSize;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x254")]
		protected int m_AutoSizeIterationCount;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x258")]
		protected int m_AutoSizeMaxIterationCount;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x25C")]
		protected bool m_IsAutoSizePointSizeSet;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		protected float m_fontSizeMin;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		protected float m_fontSizeMax;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		protected FontStyles m_fontStyle;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x26C")]
		protected FontStyles m_FontStyleInternal;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x270")]
		protected TMP_FontStyleStack m_fontStyleStack;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x27A")]
		protected bool m_isUsingBold;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x27C")]
		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x284")]
		[SerializeField]
		[FormerlySerializedAs("m_lineJustification")]
		protected TextAlignmentOptions m_textAlignment;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x288")]
		protected HorizontalAlignmentOptions m_lineJustification;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x290")]
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x2B0")]
		protected Vector3[] m_textContainerLocalCorners;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		protected float m_characterSpacing;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x2BC")]
		protected float m_cSpacing;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x2C0")]
		protected float m_monoSpacing;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x2C4")]
		[SerializeField]
		protected float m_wordSpacing;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		protected float m_lineSpacing;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x2CC")]
		protected float m_lineSpacingDelta;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x2D0")]
		protected float m_lineHeight;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x2D4")]
		protected bool m_IsDrivenLineSpacing;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		protected float m_lineSpacingMax;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x2DC")]
		[SerializeField]
		protected float m_paragraphSpacing;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		protected float m_charWidthMaxAdj;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x2E4")]
		protected float m_charWidthAdjDelta;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		protected bool m_enableWordWrapping;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x2E9")]
		protected bool m_isCharacterWrappingEnabled;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x2EA")]
		protected bool m_isNonBreakingSpace;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x2EB")]
		protected bool m_isIgnoringAlignment;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x2EC")]
		[SerializeField]
		protected float m_wordWrappingRatios;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x2F0")]
		[SerializeField]
		protected TextOverflowModes m_overflowMode;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x2F4")]
		protected int m_firstOverflowCharacterIndex;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		protected TMP_Text m_linkedTextComponent;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x300")]
		[SerializeField]
		internal TMP_Text parentLinkedComponent;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x308")]
		protected bool m_isTextTruncated;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x309")]
		[SerializeField]
		protected bool m_enableKerning;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x30C")]
		protected float m_GlyphHorizontalAdvanceAdjustment;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x310")]
		[SerializeField]
		protected bool m_enableExtraPadding;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x311")]
		[SerializeField]
		protected bool checkPaddingRequired;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x312")]
		[SerializeField]
		protected bool m_isRichText;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x313")]
		[SerializeField]
		protected bool m_parseCtrlCharacters;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x314")]
		protected bool m_isOverlay;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x315")]
		[SerializeField]
		protected bool m_isOrthographic;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x316")]
		[SerializeField]
		protected bool m_isCullingEnabled;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x317")]
		protected bool m_isMaskingEnabled;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x318")]
		protected bool isMaskUpdateRequired;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x319")]
		protected bool m_ignoreCulling;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x31C")]
		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x320")]
		[SerializeField]
		protected TextureMappingOptions m_verticalMapping;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x324")]
		[SerializeField]
		protected float m_uvLineOffset;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x328")]
		protected TextRenderFlags m_renderMode;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x32C")]
		[SerializeField]
		protected VertexSortingOrder m_geometrySortingOrder;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x330")]
		[SerializeField]
		protected bool m_IsTextObjectScaleStatic;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x331")]
		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x334")]
		protected int m_firstVisibleCharacter;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x338")]
		protected int m_maxVisibleCharacters;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x33C")]
		protected int m_maxVisibleWords;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x340")]
		protected int m_maxVisibleLines;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x344")]
		[SerializeField]
		protected bool m_useMaxVisibleDescender;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x348")]
		[SerializeField]
		protected int m_pageToDisplay;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x34C")]
		protected bool m_isNewPage;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x350")]
		[SerializeField]
		protected Vector4 m_margin;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x360")]
		protected float m_marginLeft;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x364")]
		protected float m_marginRight;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x368")]
		protected float m_marginWidth;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x36C")]
		protected float m_marginHeight;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x370")]
		protected float m_width;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x378")]
		protected TMP_TextInfo m_textInfo;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x380")]
		protected bool m_havePropertiesChanged;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x381")]
		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x388")]
		protected Transform m_transform;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x390")]
		protected RectTransform m_rectTransform;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x398")]
		protected Vector2 m_PreviousRectTransformSize;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x3A0")]
		protected Vector2 m_PreviousPivotPosition;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x3A9")]
		protected bool m_autoSizeTextContainer;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x3B0")]
		protected Mesh m_mesh;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x3B8")]
		[SerializeField]
		protected bool m_isVolumetricText;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x3C8")]
		protected TMP_SpriteAnimator m_spriteAnimator;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x3D0")]
		protected float m_flexibleHeight;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x3D4")]
		protected float m_flexibleWidth;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x3D8")]
		protected float m_minWidth;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x3DC")]
		protected float m_minHeight;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x3E0")]
		protected float m_maxWidth;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x3E4")]
		protected float m_maxHeight;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x3E8")]
		protected LayoutElement m_LayoutElement;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x3F0")]
		protected float m_preferredWidth;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x3F4")]
		protected float m_renderedWidth;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x3F8")]
		protected bool m_isPreferredWidthDirty;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x3FC")]
		protected float m_preferredHeight;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x400")]
		protected float m_renderedHeight;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x404")]
		protected bool m_isPreferredHeightDirty;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x405")]
		protected bool m_isCalculatingPreferredValues;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x408")]
		protected int m_layoutPriority;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x40C")]
		protected bool m_isLayoutDirty;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x40D")]
		protected bool m_isAwake;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x40E")]
		internal bool m_isWaitingOnResourceLoad;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x410")]
		internal TMP_Text.TextInputSources m_inputSource;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x414")]
		protected float m_fontScaleMultiplier;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x80")]
		private static char[] m_htmlTag;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x88")]
		private static RichTextTagAttribute[] m_xmlAttribute;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x90")]
		private static float[] m_attributeParameterValues;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x418")]
		protected float tag_LineIndent;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x41C")]
		protected float tag_Indent;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x420")]
		protected TMP_TextProcessingStack<float> m_indentStack;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x440")]
		protected bool tag_NoParsing;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x441")]
		protected bool m_isParsingText;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x444")]
		protected Matrix4x4 m_FXMatrix;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x484")]
		protected bool m_isFXMatrixSet;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x488")]
		internal TMP_Text.UnicodeChar[] m_TextProcessingArray;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x490")]
		internal int m_InternalTextProcessingArraySize;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x498")]
		private TMP_CharacterInfo[] m_internalCharacterInfo;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x4A0")]
		protected int m_totalCharacterCount;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x98")]
		protected static WordWrapState m_SavedWordWrapState;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x410")]
		protected static WordWrapState m_SavedLineState;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x788")]
		protected static WordWrapState m_SavedEllipsisState;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0xB00")]
		protected static WordWrapState m_SavedLastValidState;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0xE78")]
		protected static WordWrapState m_SavedSoftLineBreakState;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x11F0")]
		internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x4A4")]
		protected int m_characterCount;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x4A8")]
		protected int m_firstCharacterOfLine;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x4AC")]
		protected int m_firstVisibleCharacterOfLine;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x4B0")]
		protected int m_lastCharacterOfLine;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x4B4")]
		protected int m_lastVisibleCharacterOfLine;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x4B8")]
		protected int m_lineNumber;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x4BC")]
		protected int m_lineVisibleCharacterCount;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x4C0")]
		protected int m_pageNumber;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x4C4")]
		protected float m_PageAscender;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x4C8")]
		protected float m_maxTextAscender;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x4CC")]
		protected float m_maxCapHeight;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x4D0")]
		protected float m_ElementAscender;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x4D4")]
		protected float m_ElementDescender;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x4D8")]
		protected float m_maxLineAscender;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x4DC")]
		protected float m_maxLineDescender;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x4E0")]
		protected float m_startOfLineAscender;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x4E4")]
		protected float m_startOfLineDescender;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x4E8")]
		protected float m_lineOffset;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x4EC")]
		protected Extents m_meshExtents;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x4FC")]
		protected Color32 m_htmlColor;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x500")]
		protected TMP_TextProcessingStack<Color32> m_colorStack;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x520")]
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x540")]
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x560")]
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x590")]
		protected TMP_ColorGradient m_colorGradientPreset;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x598")]
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x5C0")]
		protected bool m_colorGradientPresetIsTinted;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x5C4")]
		protected float m_tabSpacing;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x5C8")]
		protected float m_spacing;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x5D0")]
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x5D8")]
		protected int m_TextStyleStackDepth;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x5E0")]
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x600")]
		protected int m_ItalicAngle;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x608")]
		protected TMP_TextProcessingStack<int> m_actionStack;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x628")]
		protected float m_padding;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x62C")]
		protected float m_baselineOffset;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x630")]
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x650")]
		protected float m_xAdvance;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x654")]
		protected TMP_TextElementType m_textElementType;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x658")]
		protected TMP_TextElement m_cached_TextElement;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x660")]
		protected TMP_Text.SpecialCharacter m_Ellipsis;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x680")]
		protected TMP_Text.SpecialCharacter m_Underline;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x6A0")]
		protected TMP_SpriteAsset m_defaultSpriteAsset;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x6A8")]
		protected TMP_SpriteAsset m_currentSpriteAsset;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x6B0")]
		protected int m_spriteCount;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x6B4")]
		protected int m_spriteIndex;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x6B8")]
		protected int m_spriteAnimationID;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x1588")]
		private static ProfilerMarker k_ParseTextMarker;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x1590")]
		private static ProfilerMarker k_InsertNewLineMarker;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x6BC")]
		protected bool m_ignoreActiveState;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x6C0")]
		private TMP_Text.TextBackingContainer m_TextBackingArray;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x6D0")]
		private readonly decimal[] k_Power;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x1598")]
		protected static Vector2 k_LargePositiveVector2;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x15A0")]
		protected static Vector2 k_LargeNegativeVector2;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x15A8")]
		protected static float k_LargePositiveFloat;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x15AC")]
		protected static float k_LargeNegativeFloat;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x15B0")]
		protected static int k_LargePositiveInt;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x15B4")]
		protected static int k_LargeNegativeInt;

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		protected struct CharacterSubstitution
		{
			// Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public CharacterSubstitution(int index, uint unicode)
			{
			}

			// Token: 0x040005A0 RID: 1440
			[Token(Token = "0x40005A0")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x040005A1 RID: 1441
			[Token(Token = "0x40005A1")]
			[FieldOffset(Offset = "0x4")]
			public uint unicode;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		internal enum TextInputSources
		{
			// Token: 0x040005A3 RID: 1443
			[Token(Token = "0x40005A3")]
			TextInputBox,
			// Token: 0x040005A4 RID: 1444
			[Token(Token = "0x40005A4")]
			SetText,
			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			SetTextArray,
			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			TextString
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
		internal struct UnicodeChar
		{
			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			[FieldOffset(Offset = "0x0")]
			public int unicode;

			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			[FieldOffset(Offset = "0x4")]
			public int stringIndex;

			// Token: 0x040005A9 RID: 1449
			[Token(Token = "0x40005A9")]
			[FieldOffset(Offset = "0x8")]
			public int length;
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		protected struct SpecialCharacter
		{
			// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x58C4390", Offset = "0x58C2F90", VA = "0x1858C4390")]
			public SpecialCharacter(TMP_Character character, int materialIndex)
			{
			}

			// Token: 0x040005AA RID: 1450
			[Token(Token = "0x40005AA")]
			[FieldOffset(Offset = "0x0")]
			public TMP_Character character;

			// Token: 0x040005AB RID: 1451
			[Token(Token = "0x40005AB")]
			[FieldOffset(Offset = "0x8")]
			public TMP_FontAsset fontAsset;

			// Token: 0x040005AC RID: 1452
			[Token(Token = "0x40005AC")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			// Token: 0x040005AD RID: 1453
			[Token(Token = "0x40005AD")]
			[FieldOffset(Offset = "0x18")]
			public int materialIndex;
		}

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x2000096")]
		private struct TextBackingContainer
		{
			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00004440 File Offset: 0x00002640
			[Token(Token = "0x17000164")]
			public int Capacity
			{
				[Token(Token = "0x60005D1")]
				[Address(RVA = "0x47D68A0", Offset = "0x47D54A0", VA = "0x1847D68A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00004458 File Offset: 0x00002658
			// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000165")]
			public int Count
			{
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
				set
				{
				}
			}

			// Token: 0x17000166 RID: 358
			[Token(Token = "0x17000166")]
			public uint this[int index]
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x58D8170", Offset = "0x58D6D70", VA = "0x1858D8170")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x58D81A0", Offset = "0x58D6DA0", VA = "0x1858D81A0")]
				set
				{
				}
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x58D8110", Offset = "0x58D6D10", VA = "0x1858D8110")]
			public TextBackingContainer(int size)
			{
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x58D80C0", Offset = "0x58D6CC0", VA = "0x1858D80C0")]
			public void Resize(int size)
			{
			}

			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			[FieldOffset(Offset = "0x0")]
			private uint[] m_Array;

			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x8")]
			private int m_Count;
		}
	}
}

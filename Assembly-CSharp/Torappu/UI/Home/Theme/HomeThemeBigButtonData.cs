using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C52 RID: 19538
	[Token(Token = "0x2004C52")]
	public class HomeThemeBigButtonData : HomeThemeUIElemData
	{
		// Token: 0x0601D520 RID: 120096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D520")]
		[Address(RVA = "0x16E4D80", Offset = "0x16E3980", VA = "0x1816E4D80", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D521 RID: 120097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D521")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeBigButtonData()
		{
		}

		// Token: 0x04026940 RID: 158016
		[Token(Token = "0x4026940")]
		private const string BUILDING_BTN = "btn_building";

		// Token: 0x04026941 RID: 158017
		[Token(Token = "0x4026941")]
		private const string BETA = "_beta";

		// Token: 0x04026942 RID: 158018
		[Token(Token = "0x4026942")]
		[FieldOffset(Offset = "0x28")]
		public string imgPrefab;

		// Token: 0x04026943 RID: 158019
		[Token(Token = "0x4026943")]
		[FieldOffset(Offset = "0x30")]
		public HomeThemeBigButtonData.ImageData imgData;

		// Token: 0x04026944 RID: 158020
		[Token(Token = "0x4026944")]
		[FieldOffset(Offset = "0x38")]
		public HomeThemeBigButtonData.ImageData bgData;

		// Token: 0x02004C53 RID: 19539
		[Token(Token = "0x2004C53")]
		public class ImageData
		{
			// Token: 0x0601D522 RID: 120098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D522")]
			[Address(RVA = "0x16E9A50", Offset = "0x16E8650", VA = "0x1816E9A50")]
			public void ParseFromJson(JObject jdata)
			{
			}

			// Token: 0x0601D523 RID: 120099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D523")]
			[Address(RVA = "0x16E9900", Offset = "0x16E8500", VA = "0x1816E9900")]
			public void FillUIData(Image image, AssetPathConvertor pathConvertor)
			{
			}

			// Token: 0x0601D524 RID: 120100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D524")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ImageData()
			{
			}

			// Token: 0x04026945 RID: 158021
			[Token(Token = "0x4026945")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pos;

			// Token: 0x04026946 RID: 158022
			[Token(Token = "0x4026946")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 size;

			// Token: 0x04026947 RID: 158023
			[Token(Token = "0x4026947")]
			[FieldOffset(Offset = "0x20")]
			public string spritePath;

			// Token: 0x04026948 RID: 158024
			[Token(Token = "0x4026948")]
			[FieldOffset(Offset = "0x28")]
			public string matPath;

			// Token: 0x04026949 RID: 158025
			[Token(Token = "0x4026949")]
			[FieldOffset(Offset = "0x30")]
			[JsonConverter(typeof(StringEnumConverter))]
			public Image.Type imgType;
		}
	}
}

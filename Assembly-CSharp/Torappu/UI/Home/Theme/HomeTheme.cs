using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6D RID: 19565
	[Token(Token = "0x2004C6D")]
	public class HomeTheme : UIStyle
	{
		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x0601D58C RID: 120204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D58D RID: 120205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044E5")]
		public string themeId
		{
			[Token(Token = "0x601D58C")]
			[Address(RVA = "0x16E97A0", Offset = "0x16E83A0", VA = "0x1816E97A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D58D")]
			[Address(RVA = "0x16E9880", Offset = "0x16E8480", VA = "0x1816E9880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x0601D58E RID: 120206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D58F RID: 120207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044E6")]
		public JObject jdata
		{
			[Token(Token = "0x601D58E")]
			[Address(RVA = "0x16E9740", Offset = "0x16E8340", VA = "0x1816E9740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D58F")]
			[Address(RVA = "0x16E9800", Offset = "0x16E8400", VA = "0x1816E9800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D590 RID: 120208 RVA: 0x000AB390 File Offset: 0x000A9590
		[Token(Token = "0x601D590")]
		[Address(RVA = "0x16E9260", Offset = "0x16E7E60", VA = "0x1816E9260")]
		public bool Load(string nThemeId)
		{
			return default(bool);
		}

		// Token: 0x0601D591 RID: 120209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D591")]
		[Address(RVA = "0x16E9520", Offset = "0x16E8120", VA = "0x1816E9520")]
		public void Unload()
		{
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D592")]
		public T LoadAsset<T>(string resPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x000AB3A8 File Offset: 0x000A95A8
		[Token(Token = "0x601D593")]
		[Address(RVA = "0x16E9680", Offset = "0x16E8280", VA = "0x1816E9680")]
		private int _GetAssetGroup()
		{
			return 0;
		}

		// Token: 0x0601D594 RID: 120212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D594")]
		[Address(RVA = "0x16E94C0", Offset = "0x16E80C0", VA = "0x1816E94C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D595 RID: 120213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D595")]
		[Address(RVA = "0x16E96E0", Offset = "0x16E82E0", VA = "0x1816E96E0")]
		public HomeTheme()
		{
		}

		// Token: 0x040269B7 RID: 158135
		[Token(Token = "0x40269B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_themeId;

		// Token: 0x040269B8 RID: 158136
		[Token(Token = "0x40269B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_themeId;

		// Token: 0x040269B9 RID: 158137
		[Token(Token = "0x40269B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_jdata;

		// Token: 0x040269BA RID: 158138
		[Token(Token = "0x40269BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_jdata;

		// Token: 0x040269BB RID: 158139
		[Token(Token = "0x40269BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x040269BC RID: 158140
		[Token(Token = "0x40269BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Unload;

		// Token: 0x040269BD RID: 158141
		[Token(Token = "0x40269BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x040269BE RID: 158142
		[Token(Token = "0x40269BE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetAssetGroup;

		// Token: 0x040269BF RID: 158143
		[Token(Token = "0x40269BF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040269C0 RID: 158144
		[Token(Token = "0x40269C0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

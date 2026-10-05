using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006967 RID: 26983
	[Token(Token = "0x2006967")]
	public class StageKeyItemUnlockDialog : UICompDialog<StageKeyItemUnlockDialog.Options>
	{
		// Token: 0x060269D3 RID: 158163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D3")]
		[Address(RVA = "0x21ACCA0", Offset = "0x21AB8A0", VA = "0x1821ACCA0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060269D4 RID: 158164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269D4")]
		[Address(RVA = "0x21ACB80", Offset = "0x21AB780", VA = "0x1821ACB80", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060269D5 RID: 158165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D5")]
		[Address(RVA = "0x21ACDB0", Offset = "0x21AB9B0", VA = "0x1821ACDB0", Slot = "18")]
		protected override void OnRender(StageKeyItemUnlockDialog.Options options)
		{
		}

		// Token: 0x060269D6 RID: 158166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D6")]
		[Address(RVA = "0x21ACBE0", Offset = "0x21AB7E0", VA = "0x1821ACBE0")]
		public void OnBackPressed()
		{
		}

		// Token: 0x060269D7 RID: 158167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D7")]
		[Address(RVA = "0x21AD0D0", Offset = "0x21ABCD0", VA = "0x1821AD0D0")]
		public void OnUnlockClick()
		{
		}

		// Token: 0x060269D8 RID: 158168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D8")]
		[Address(RVA = "0x21AD180", Offset = "0x21ABD80", VA = "0x1821AD180")]
		public StageKeyItemUnlockDialog()
		{
		}

		// Token: 0x060269D9 RID: 158169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D9")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x060269DA RID: 158170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269DA")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040367DE RID: 223198
		[Token(Token = "0x40367DE")]
		private const string BKG_ID_FORMAT = "{0}_{1}";

		// Token: 0x040367DF RID: 223199
		[Token(Token = "0x40367DF")]
		private const string BKG_SUFFIX_UNLOCKED = "unlocked";

		// Token: 0x040367E0 RID: 223200
		[Token(Token = "0x40367E0")]
		private const string BKG_SUFFIX_LOCKED = "locked";

		// Token: 0x040367E1 RID: 223201
		[Token(Token = "0x40367E1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _knownObj;

		// Token: 0x040367E2 RID: 223202
		[Token(Token = "0x40367E2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _unknownObj;

		// Token: 0x040367E3 RID: 223203
		[Token(Token = "0x40367E3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x040367E4 RID: 223204
		[Token(Token = "0x40367E4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x040367E5 RID: 223205
		[Token(Token = "0x40367E5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _unlockDesc;

		// Token: 0x040367E6 RID: 223206
		[Token(Token = "0x40367E6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x040367E7 RID: 223207
		[Token(Token = "0x40367E7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040367E8 RID: 223208
		[Token(Token = "0x40367E8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIRenderTextureImage _blur;

		// Token: 0x040367E9 RID: 223209
		[Token(Token = "0x40367E9")]
		[FieldOffset(Offset = "0xB0")]
		private string m_stageId;

		// Token: 0x040367EA RID: 223210
		[Token(Token = "0x40367EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040367EB RID: 223211
		[Token(Token = "0x40367EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040367EC RID: 223212
		[Token(Token = "0x40367EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040367ED RID: 223213
		[Token(Token = "0x40367ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackPressed;

		// Token: 0x040367EE RID: 223214
		[Token(Token = "0x40367EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUnlockClick;

		// Token: 0x040367EF RID: 223215
		[Token(Token = "0x40367EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006968 RID: 26984
		[Token(Token = "0x2006968")]
		public class Options
		{
			// Token: 0x060269DB RID: 158171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60269DB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040367F0 RID: 223216
			[Token(Token = "0x40367F0")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040367F1 RID: 223217
			[Token(Token = "0x40367F1")]
			[FieldOffset(Offset = "0x18")]
			public string stageCode;

			// Token: 0x040367F2 RID: 223218
			[Token(Token = "0x40367F2")]
			[FieldOffset(Offset = "0x20")]
			public string stageName;

			// Token: 0x040367F3 RID: 223219
			[Token(Token = "0x40367F3")]
			[FieldOffset(Offset = "0x28")]
			public bool ableToUnlock;

			// Token: 0x040367F4 RID: 223220
			[Token(Token = "0x40367F4")]
			[FieldOffset(Offset = "0x30")]
			public string unlockDesc;

			// Token: 0x040367F5 RID: 223221
			[Token(Token = "0x40367F5")]
			[FieldOffset(Offset = "0x38")]
			public string keyItemId;
		}
	}
}

using System;
using Il2CppDummyDll;
using Torappu.I18N;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016A0 RID: 5792
	[Token(Token = "0x20016A0")]
	public abstract class BaseTextDB<TSubDB> : ConstTable<LanguageData, TSubDB>, FlatBufferSignedConverter.IPreprocessTextData, I18nUtils.ITextProvider where TSubDB : ConstTable<LanguageData, TSubDB>
	{
		// Token: 0x060092B4 RID: 37556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092B4")]
		public object Preprocess(object data, JsonNetConverter jsonConverter)
		{
			return null;
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B5")]
		protected override void OnInit()
		{
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x00039168 File Offset: 0x00037368
		[Token(Token = "0x60092B6")]
		public bool TryGetText(string textId, out string text)
		{
			return default(bool);
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B7")]
		protected BaseTextDB()
		{
		}

		// Token: 0x04008856 RID: 34902
		[Token(Token = "0x4008856")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("AssetPath of build-in text table which would be merged")]
		private string _buildinData;

		// Token: 0x04008857 RID: 34903
		[Token(Token = "0x4008857")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04008858 RID: 34904
		[Token(Token = "0x4008858")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008859 RID: 34905
		[Token(Token = "0x4008859")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetText;

		// Token: 0x0400885A RID: 34906
		[Token(Token = "0x400885A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

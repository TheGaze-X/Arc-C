using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD9 RID: 23513
	[Token(Token = "0x2005BD9")]
	public abstract class TemplateCharSelectDetailPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022186 RID: 139654
		[Token(Token = "0x6022186")]
		public abstract void OnRender(TemplateCharSelectMainViewModel mainModel, TemplateCharSelectDetailPlugin.RenderType renderType);

		// Token: 0x06022187 RID: 139655
		[Token(Token = "0x6022187")]
		public abstract void OnChangeState(TemplateCharSelectDetailPlugin.ButtonType btnType);

		// Token: 0x06022188 RID: 139656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022188")]
		[Address(RVA = "0x1C9C9F0", Offset = "0x1C9B5F0", VA = "0x181C9C9F0")]
		protected TemplateCharSelectDetailPlugin()
		{
		}

		// Token: 0x0402EC46 RID: 191558
		[Token(Token = "0x402EC46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BDA RID: 23514
		[Token(Token = "0x2005BDA")]
		[Serializable]
		public enum ButtonType
		{
			// Token: 0x0402EC48 RID: 191560
			[Token(Token = "0x402EC48")]
			SKILL,
			// Token: 0x0402EC49 RID: 191561
			[Token(Token = "0x402EC49")]
			BRANCH
		}

		// Token: 0x02005BDB RID: 23515
		[Token(Token = "0x2005BDB")]
		[Serializable]
		public enum RenderType
		{
			// Token: 0x0402EC4B RID: 191563
			[Token(Token = "0x402EC4B")]
			EMPTY,
			// Token: 0x0402EC4C RID: 191564
			[Token(Token = "0x402EC4C")]
			CHAR_DETAIL
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DFA RID: 19962
	[Token(Token = "0x2004DFA")]
	public abstract class NameCardV2ModuleVirtualView<TView, TModel> : NameCardV2MoudleVirtualView where TView : NameCardV2BaseModuleView where TModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DD56 RID: 122198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD56")]
		public NameCardV2ModuleVirtualView(NameCardV2BaseModuleView prefab, NameCardV2ModuleBaseModel model)
		{
		}

		// Token: 0x0601DD57 RID: 122199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD57")]
		protected sealed override void OnViewAttached()
		{
		}

		// Token: 0x0601DD58 RID: 122200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD58")]
		protected sealed override void OnViewDetached()
		{
		}

		// Token: 0x0601DD59 RID: 122201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DD59")]
		public sealed override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0601DD5A RID: 122202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD5A")]
		public sealed override void RenderModuleView(NameCardV2ModuleBaseModel model)
		{
		}

		// Token: 0x0402787C RID: 161916
		[Token(Token = "0x402787C")]
		[FieldOffset(Offset = "0x0")]
		protected TView m_prefab;

		// Token: 0x0402787D RID: 161917
		[Token(Token = "0x402787D")]
		[FieldOffset(Offset = "0x0")]
		protected TModel m_model;

		// Token: 0x0402787E RID: 161918
		[Token(Token = "0x402787E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402787F RID: 161919
		[Token(Token = "0x402787F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04027880 RID: 161920
		[Token(Token = "0x4027880")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04027881 RID: 161921
		[Token(Token = "0x4027881")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04027882 RID: 161922
		[Token(Token = "0x4027882")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderModuleView;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DFC RID: 19964
	[Token(Token = "0x2004DFC")]
	public abstract class NameCardV2RemovableModuleVirtualView<TView, TModel> : NameCardV2RemovableModuleVirtualView where TView : NameCardV2BaseRemovableModuleView<TModel> where TModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x0601DD60 RID: 122208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD60")]
		protected NameCardV2RemovableModuleVirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
		{
		}

		// Token: 0x0601DD61 RID: 122209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD61")]
		protected sealed override void OnViewAttached()
		{
		}

		// Token: 0x0601DD62 RID: 122210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DD62")]
		public sealed override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0601DD63 RID: 122211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD63")]
		protected sealed override void OnViewDetached()
		{
		}

		// Token: 0x0601DD64 RID: 122212 RVA: 0x000AC788 File Offset: 0x000AA988
		[Token(Token = "0x601DD64")]
		public sealed override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0601DD65 RID: 122213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD65")]
		public sealed override void PlaySelectTween(bool isShow)
		{
		}

		// Token: 0x0601DD66 RID: 122214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD66")]
		public sealed override void ResetSelectTween(bool isShow)
		{
		}

		// Token: 0x0601DD67 RID: 122215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD67")]
		public sealed override void RenderModuleView(NameCardV2ModuleBaseModel model)
		{
		}

		// Token: 0x0601DD68 RID: 122216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD68")]
		public sealed override void SetHidenOption(Action onHiden)
		{
		}

		// Token: 0x04027886 RID: 161926
		[Token(Token = "0x4027886")]
		[FieldOffset(Offset = "0x0")]
		protected TView m_prefab;

		// Token: 0x04027887 RID: 161927
		[Token(Token = "0x4027887")]
		[FieldOffset(Offset = "0x0")]
		protected TModel m_model;

		// Token: 0x04027888 RID: 161928
		[Token(Token = "0x4027888")]
		[FieldOffset(Offset = "0x0")]
		private float m_dynamicHeight;

		// Token: 0x04027889 RID: 161929
		[Token(Token = "0x4027889")]
		[FieldOffset(Offset = "0x0")]
		private NameCardV2RemovableModuleVirtualView<TView, TModel>.SelectTween m_tween;

		// Token: 0x0402788A RID: 161930
		[Token(Token = "0x402788A")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isShow;

		// Token: 0x0402788B RID: 161931
		[Token(Token = "0x402788B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402788C RID: 161932
		[Token(Token = "0x402788C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x0402788D RID: 161933
		[Token(Token = "0x402788D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0402788E RID: 161934
		[Token(Token = "0x402788E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0402788F RID: 161935
		[Token(Token = "0x402788F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04027890 RID: 161936
		[Token(Token = "0x4027890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlaySelectTween;

		// Token: 0x04027891 RID: 161937
		[Token(Token = "0x4027891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResetSelectTween;

		// Token: 0x04027892 RID: 161938
		[Token(Token = "0x4027892")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderModuleView;

		// Token: 0x04027893 RID: 161939
		[Token(Token = "0x4027893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetHidenOption;

		// Token: 0x02004DFD RID: 19965
		[Token(Token = "0x2004DFD")]
		private class SelectTween : UISwitchTween
		{
			// Token: 0x0601DD69 RID: 122217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD69")]
			public SelectTween(NameCardV2RemovableModuleVirtualView<TView, TModel> closure, NameCardV2BaseRemovableModuleView<TModel> prefab)
			{
			}

			// Token: 0x0601DD6A RID: 122218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD6A")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601DD6B RID: 122219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD6B")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601DD6C RID: 122220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD6C")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601DD6D RID: 122221 RVA: 0x000AC7A0 File Offset: 0x000AA9A0
			[Token(Token = "0x601DD6D")]
			private float _GetValue()
			{
				return 0f;
			}

			// Token: 0x0601DD6E RID: 122222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD6E")]
			private void _SetValue(float value)
			{
			}

			// Token: 0x04027894 RID: 161940
			[Token(Token = "0x4027894")]
			[FieldOffset(Offset = "0x0")]
			private NameCardV2RemovableModuleVirtualView<TView, TModel> m_closure;

			// Token: 0x04027895 RID: 161941
			[Token(Token = "0x4027895")]
			[FieldOffset(Offset = "0x0")]
			private NameCardV2BaseRemovableModuleView<TModel> m_prefab;

			// Token: 0x04027896 RID: 161942
			[Token(Token = "0x4027896")]
			[FieldOffset(Offset = "0x0")]
			private float m_value;

			// Token: 0x04027897 RID: 161943
			[Token(Token = "0x4027897")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027898 RID: 161944
			[Token(Token = "0x4027898")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04027899 RID: 161945
			[Token(Token = "0x4027899")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402789A RID: 161946
			[Token(Token = "0x402789A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402789B RID: 161947
			[Token(Token = "0x402789B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__GetValue;

			// Token: 0x0402789C RID: 161948
			[Token(Token = "0x402789C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__SetValue;
		}
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C65 RID: 15461
	[Token(Token = "0x2003C65")]
	public class TuningChatPredelayComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601827D RID: 98941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601827D")]
		[Address(RVA = "0x10905D0", Offset = "0x108F1D0", VA = "0x1810905D0")]
		private void _SetDisplay(bool isShow, bool useFastMode)
		{
		}

		// Token: 0x0601827E RID: 98942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601827E")]
		[Address(RVA = "0x1090700", Offset = "0x108F300", VA = "0x181090700")]
		public TuningChatPredelayComp()
		{
		}

		// Token: 0x0401D5EB RID: 120299
		[Token(Token = "0x401D5EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferedHeight;

		// Token: 0x0401D5EC RID: 120300
		[Token(Token = "0x401D5EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401D5ED RID: 120301
		[Token(Token = "0x401D5ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401D5EE RID: 120302
		[Token(Token = "0x401D5EE")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0401D5EF RID: 120303
		[Token(Token = "0x401D5EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x0401D5F0 RID: 120304
		[Token(Token = "0x401D5F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C66 RID: 15462
		[Token(Token = "0x2003C66")]
		public class VirtualView : AVGChatVirtualView<TuningChatPredelayComp>, IChatDelayView, UIRecycleLayoutAdapter.IVirtualView, IHotfixable
		{
			// Token: 0x0601827F RID: 98943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601827F")]
			[Address(RVA = "0x10BA8A0", Offset = "0x10B94A0", VA = "0x1810BA8A0")]
			public VirtualView(TuningChatPredelayComp prefab)
			{
			}

			// Token: 0x06018280 RID: 98944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018280")]
			[Address(RVA = "0x10BA6F0", Offset = "0x10B92F0", VA = "0x1810BA6F0", Slot = "26")]
			public void ResetDelay(float delay)
			{
			}

			// Token: 0x06018281 RID: 98945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018281")]
			[Address(RVA = "0x10BA110", Offset = "0x10B8D10", VA = "0x1810BA110", Slot = "12")]
			public sealed override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06018282 RID: 98946 RVA: 0x00099948 File Offset: 0x00097B48
			[Token(Token = "0x6018282")]
			[Address(RVA = "0x10BA180", Offset = "0x10B8D80", VA = "0x1810BA180", Slot = "13")]
			public sealed override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06018283 RID: 98947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018283")]
			[Address(RVA = "0x10BA320", Offset = "0x10B8F20", VA = "0x1810BA320", Slot = "20")]
			protected override void HideViewContent(TuningChatPredelayComp view)
			{
			}

			// Token: 0x06018284 RID: 98948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018284")]
			[Address(RVA = "0x10BA400", Offset = "0x10B9000", VA = "0x1810BA400", Slot = "22")]
			protected override void OnUpdateView(TuningChatPredelayComp view)
			{
			}

			// Token: 0x06018285 RID: 98949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018285")]
			[Address(RVA = "0x10BA640", Offset = "0x10B9240", VA = "0x1810BA640", Slot = "21")]
			protected override IEnumerator PlayViewContent(TuningChatPredelayComp view)
			{
				return null;
			}

			// Token: 0x06018286 RID: 98950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018286")]
			[Address(RVA = "0x10BA760", Offset = "0x10B9360", VA = "0x1810BA760", Slot = "23")]
			protected override void ShowAsLog(TuningChatPredelayComp view)
			{
			}

			// Token: 0x0401D5F1 RID: 120305
			[Token(Token = "0x401D5F1")]
			[FieldOffset(Offset = "0x28")]
			private TuningChatPredelayComp m_prefab;

			// Token: 0x0401D5F2 RID: 120306
			[Token(Token = "0x401D5F2")]
			[FieldOffset(Offset = "0x30")]
			private float m_cachedHeight;

			// Token: 0x0401D5F3 RID: 120307
			[Token(Token = "0x401D5F3")]
			[FieldOffset(Offset = "0x34")]
			private float m_delay;

			// Token: 0x0401D5F4 RID: 120308
			[Token(Token = "0x401D5F4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D5F5 RID: 120309
			[Token(Token = "0x401D5F5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ResetDelay;

			// Token: 0x0401D5F6 RID: 120310
			[Token(Token = "0x401D5F6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401D5F7 RID: 120311
			[Token(Token = "0x401D5F7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401D5F8 RID: 120312
			[Token(Token = "0x401D5F8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401D5F9 RID: 120313
			[Token(Token = "0x401D5F9")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401D5FA RID: 120314
			[Token(Token = "0x401D5FA")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401D5FB RID: 120315
			[Token(Token = "0x401D5FB")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ShowAsLog;
		}
	}
}

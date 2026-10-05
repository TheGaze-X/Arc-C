using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200412E RID: 16686
	[Token(Token = "0x200412E")]
	public abstract class SandboxV2StateBindingPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C58 RID: 105560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C58")]
		[Address(RVA = "0x12B6130", Offset = "0x12B4D30", VA = "0x1812B6130")]
		private void Awake()
		{
		}

		// Token: 0x06019C59 RID: 105561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C59")]
		[Address(RVA = "0x12B62F0", Offset = "0x12B4EF0", VA = "0x1812B62F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019C5A RID: 105562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C5A")]
		[Address(RVA = "0x12B6440", Offset = "0x12B5040", VA = "0x1812B6440")]
		public void OnStateChanged(Type stateType)
		{
		}

		// Token: 0x06019C5B RID: 105563
		[Token(Token = "0x6019C5B")]
		public abstract void SetShow(bool isShow);

		// Token: 0x06019C5C RID: 105564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C5C")]
		[Address(RVA = "0x12B65A0", Offset = "0x12B51A0", VA = "0x1812B65A0")]
		protected SandboxV2StateBindingPanel()
		{
		}

		// Token: 0x0402050B RID: 132363
		[Token(Token = "0x402050B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<string> _enableStates;

		// Token: 0x0402050C RID: 132364
		[Token(Token = "0x402050C")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2StateBindingPanelManager m_bindingPanelManager;

		// Token: 0x0402050D RID: 132365
		[Token(Token = "0x402050D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0402050E RID: 132366
		[Token(Token = "0x402050E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402050F RID: 132367
		[Token(Token = "0x402050F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x04020510 RID: 132368
		[Token(Token = "0x4020510")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

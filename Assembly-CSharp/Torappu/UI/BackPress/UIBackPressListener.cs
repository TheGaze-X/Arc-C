using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.BackPress
{
	// Token: 0x02005C2B RID: 23595
	[Token(Token = "0x2005C2B")]
	[RequireComponent(typeof(RectTransform))]
	public class UIBackPressListener : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022347 RID: 140103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022347")]
		[Address(RVA = "0x1CB4250", Offset = "0x1CB2E50", VA = "0x181CB4250")]
		private void Start()
		{
		}

		// Token: 0x06022348 RID: 140104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022348")]
		[Address(RVA = "0x1CB41C0", Offset = "0x1CB2DC0", VA = "0x181CB41C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022349")]
		[Address(RVA = "0x1CB4130", Offset = "0x1CB2D30", VA = "0x181CB4130")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602234A")]
		[Address(RVA = "0x1CB40A0", Offset = "0x1CB2CA0", VA = "0x181CB40A0")]
		public void ManagerOnlySetOptions(BackPressOptions options)
		{
		}

		// Token: 0x0602234B RID: 140107 RVA: 0x000BCAA8 File Offset: 0x000BACA8
		[Token(Token = "0x602234B")]
		[Address(RVA = "0x1CB3ED0", Offset = "0x1CB2AD0", VA = "0x181CB3ED0")]
		public bool ManagerOnlyConsumeBackPress()
		{
			return default(bool);
		}

		// Token: 0x0602234C RID: 140108 RVA: 0x000BCAC0 File Offset: 0x000BACC0
		[Token(Token = "0x602234C")]
		[Address(RVA = "0x1CB44D0", Offset = "0x1CB30D0", VA = "0x181CB44D0")]
		private bool _CheckIfToConsume()
		{
			return default(bool);
		}

		// Token: 0x0602234D RID: 140109 RVA: 0x000BCAD8 File Offset: 0x000BACD8
		[Token(Token = "0x602234D")]
		[Address(RVA = "0x1CB43C0", Offset = "0x1CB2FC0", VA = "0x181CB43C0")]
		private bool _BreakWhenOtherListener(Transform target)
		{
			return default(bool);
		}

		// Token: 0x0602234E RID: 140110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602234E")]
		[Address(RVA = "0x1CB4640", Offset = "0x1CB3240", VA = "0x181CB4640")]
		public UIBackPressListener()
		{
		}

		// Token: 0x0402EEBF RID: 192191
		[Token(Token = "0x402EEBF")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_rectTrans;

		// Token: 0x0402EEC0 RID: 192192
		[Token(Token = "0x402EEC0")]
		[FieldOffset(Offset = "0x20")]
		private Canvas m_rootCanvas;

		// Token: 0x0402EEC1 RID: 192193
		[Token(Token = "0x402EEC1")]
		[FieldOffset(Offset = "0x28")]
		private BackPressOptions m_options;

		// Token: 0x0402EEC2 RID: 192194
		[Token(Token = "0x402EEC2")]
		[FieldOffset(Offset = "0x48")]
		private List<RaycastResult> m_raycastResults;

		// Token: 0x0402EEC3 RID: 192195
		[Token(Token = "0x402EEC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402EEC4 RID: 192196
		[Token(Token = "0x402EEC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402EEC5 RID: 192197
		[Token(Token = "0x402EEC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402EEC6 RID: 192198
		[Token(Token = "0x402EEC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ManagerOnlySetOptions;

		// Token: 0x0402EEC7 RID: 192199
		[Token(Token = "0x402EEC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ManagerOnlyConsumeBackPress;

		// Token: 0x0402EEC8 RID: 192200
		[Token(Token = "0x402EEC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIfToConsume;

		// Token: 0x0402EEC9 RID: 192201
		[Token(Token = "0x402EEC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BreakWhenOtherListener;

		// Token: 0x0402EECA RID: 192202
		[Token(Token = "0x402EECA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

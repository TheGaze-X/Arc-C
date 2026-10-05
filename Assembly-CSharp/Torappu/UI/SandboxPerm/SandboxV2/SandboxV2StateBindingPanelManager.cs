using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200412F RID: 16687
	[Token(Token = "0x200412F")]
	public class SandboxV2StateBindingPanelManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C5D RID: 105565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C5D")]
		[Address(RVA = "0x12B5CB0", Offset = "0x12B48B0", VA = "0x1812B5CB0")]
		public void Init()
		{
		}

		// Token: 0x06019C5E RID: 105566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C5E")]
		[Address(RVA = "0x12B5E50", Offset = "0x12B4A50", VA = "0x1812B5E50")]
		public void Watch(SandboxV2StateBindingPanel element)
		{
		}

		// Token: 0x06019C5F RID: 105567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C5F")]
		[Address(RVA = "0x12B5D90", Offset = "0x12B4990", VA = "0x1812B5D90")]
		public void Unwatch(SandboxV2StateBindingPanel element)
		{
		}

		// Token: 0x06019C60 RID: 105568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C60")]
		[Address(RVA = "0x12B5F20", Offset = "0x12B4B20", VA = "0x1812B5F20")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x06019C61 RID: 105569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C61")]
		[Address(RVA = "0x12B6040", Offset = "0x12B4C40", VA = "0x1812B6040")]
		public SandboxV2StateBindingPanelManager()
		{
		}

		// Token: 0x04020511 RID: 132369
		[Token(Token = "0x4020511")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04020512 RID: 132370
		[Token(Token = "0x4020512")]
		[FieldOffset(Offset = "0x20")]
		private StateEngine.OnStateChangeListener m_stateEngineListener;

		// Token: 0x04020513 RID: 132371
		[Token(Token = "0x4020513")]
		[FieldOffset(Offset = "0x28")]
		private List<SandboxV2StateBindingPanel> m_panels;

		// Token: 0x04020514 RID: 132372
		[Token(Token = "0x4020514")]
		[FieldOffset(Offset = "0x30")]
		private Type m_currTopState;

		// Token: 0x04020515 RID: 132373
		[Token(Token = "0x4020515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04020516 RID: 132374
		[Token(Token = "0x4020516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x04020517 RID: 132375
		[Token(Token = "0x4020517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Unwatch;

		// Token: 0x04020518 RID: 132376
		[Token(Token = "0x4020518")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x04020519 RID: 132377
		[Token(Token = "0x4020519")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

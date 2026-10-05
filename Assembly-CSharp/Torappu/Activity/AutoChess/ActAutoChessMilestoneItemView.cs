using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200712A RID: 28970
	[Token(Token = "0x200712A")]
	public class ActAutoChessMilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x06029240 RID: 168512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029240")]
		[Address(RVA = "0x248B1B0", Offset = "0x2489DB0", VA = "0x18248B1B0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06029241 RID: 168513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029241")]
		[Address(RVA = "0x248B560", Offset = "0x248A160", VA = "0x18248B560")]
		private void _RenderAsPending()
		{
		}

		// Token: 0x06029242 RID: 168514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029242")]
		[Address(RVA = "0x248B430", Offset = "0x248A030", VA = "0x18248B430")]
		private void _RenderAsNormal()
		{
		}

		// Token: 0x06029243 RID: 168515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029243")]
		[Address(RVA = "0x248B670", Offset = "0x248A270", VA = "0x18248B670")]
		public ActAutoChessMilestoneItemView()
		{
		}

		// Token: 0x06029244 RID: 168516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029244")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403AC08 RID: 240648
		[Token(Token = "0x403AC08")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pendingVariant;

		// Token: 0x0403AC09 RID: 240649
		[Token(Token = "0x403AC09")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _pendingDescText;

		// Token: 0x0403AC0A RID: 240650
		[Token(Token = "0x403AC0A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _normalVariant;

		// Token: 0x0403AC0B RID: 240651
		[Token(Token = "0x403AC0B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _invalidVariant;

		// Token: 0x0403AC0C RID: 240652
		[Token(Token = "0x403AC0C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _validVariant;

		// Token: 0x0403AC0D RID: 240653
		[Token(Token = "0x403AC0D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _claimedVariant;

		// Token: 0x0403AC0E RID: 240654
		[Token(Token = "0x403AC0E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0403AC0F RID: 240655
		[Token(Token = "0x403AC0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403AC10 RID: 240656
		[Token(Token = "0x403AC10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderAsPending;

		// Token: 0x0403AC11 RID: 240657
		[Token(Token = "0x403AC11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAsNormal;

		// Token: 0x0403AC12 RID: 240658
		[Token(Token = "0x403AC12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

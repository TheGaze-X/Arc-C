using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004332 RID: 17202
	[Token(Token = "0x2004332")]
	public class SandboxV2HomeMonthEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6D7 RID: 108247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D7")]
		[Address(RVA = "0x1385950", Offset = "0x1384550", VA = "0x181385950")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6D8 RID: 108248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D8")]
		[Address(RVA = "0x1385E10", Offset = "0x1384A10", VA = "0x181385E10")]
		public SandboxV2HomeMonthEntryView()
		{
		}

		// Token: 0x0402194B RID: 137547
		[Token(Token = "0x402194B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public TwoStateToggle _validToggle;

		// Token: 0x0402194C RID: 137548
		[Token(Token = "0x402194C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _disableLabel;

		// Token: 0x0402194D RID: 137549
		[Token(Token = "0x402194D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _fullstoreNode;

		// Token: 0x0402194E RID: 137550
		[Token(Token = "0x402194E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fullstoreCompleteNode;

		// Token: 0x0402194F RID: 137551
		[Token(Token = "0x402194F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _rushCountLabels;

		// Token: 0x04021950 RID: 137552
		[Token(Token = "0x4021950")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text[] _rushDoneCntLabels;

		// Token: 0x04021951 RID: 137553
		[Token(Token = "0x4021951")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _updateNode;

		// Token: 0x04021952 RID: 137554
		[Token(Token = "0x4021952")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _updateCompleteNode;

		// Token: 0x04021953 RID: 137555
		[Token(Token = "0x4021953")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _updateCDLabel;

		// Token: 0x04021954 RID: 137556
		[Token(Token = "0x4021954")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _remainCDLabel;

		// Token: 0x04021955 RID: 137557
		[Token(Token = "0x4021955")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021956 RID: 137558
		[Token(Token = "0x4021956")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

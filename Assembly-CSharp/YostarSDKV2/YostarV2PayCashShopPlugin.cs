using System;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public class YostarV2PayCashShopPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x524FA0", Offset = "0x523BA0", VA = "0x180524FA0")]
		public void Init(YostarSDKV2 sdk)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x524D20", Offset = "0x523920", VA = "0x180524D20")]
		public void EventOnJPSCTAClicked()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x524BE0", Offset = "0x5237E0", VA = "0x180524BE0")]
		public void EventOnJPFSAClicked()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x524E60", Offset = "0x523A60", VA = "0x180524E60")]
		public void EventOnKRAgreementsClicked()
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x525080", Offset = "0x523C80", VA = "0x180525080")]
		public YostarV2PayCashShopPlugin()
		{
		}

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnJPSCTA;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnJPFSA;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnKRAgreements;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _descKR;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x38")]
		private YostarSDKV2 m_sdk;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnJPSCTAClicked;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnJPFSAClicked;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnKRAgreementsClicked;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

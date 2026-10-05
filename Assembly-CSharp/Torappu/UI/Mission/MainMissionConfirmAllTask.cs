using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200488D RID: 18573
	[Token(Token = "0x200488D")]
	public class MainMissionConfirmAllTask : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C099 RID: 114841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C099")]
		[Address(RVA = "0x15655B0", Offset = "0x15641B0", VA = "0x1815655B0")]
		public void InitData()
		{
		}

		// Token: 0x0601C09A RID: 114842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C09A")]
		[Address(RVA = "0x1565550", Offset = "0x1564150", VA = "0x181565550")]
		public void ApplyAllReward()
		{
		}

		// Token: 0x0601C09B RID: 114843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C09B")]
		[Address(RVA = "0x15656C0", Offset = "0x15642C0", VA = "0x1815656C0")]
		public MainMissionConfirmAllTask()
		{
		}

		// Token: 0x0402497F RID: 149887
		[Token(Token = "0x402497F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _describeText;

		// Token: 0x04024980 RID: 149888
		[Token(Token = "0x4024980")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buttonText;

		// Token: 0x04024981 RID: 149889
		[Token(Token = "0x4024981")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04024982 RID: 149890
		[Token(Token = "0x4024982")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyAllReward;

		// Token: 0x04024983 RID: 149891
		[Token(Token = "0x4024983")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D4D RID: 27981
	[Token(Token = "0x2006D4D")]
	public class ActivityItemNameView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027E1C RID: 163356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1C")]
		[Address(RVA = "0x22F17D0", Offset = "0x22F03D0", VA = "0x1822F17D0")]
		private void Start()
		{
		}

		// Token: 0x06027E1D RID: 163357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1D")]
		[Address(RVA = "0x22F1920", Offset = "0x22F0520", VA = "0x1822F1920")]
		private void _ApplyCoinName()
		{
		}

		// Token: 0x06027E1E RID: 163358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1E")]
		[Address(RVA = "0x22F1A40", Offset = "0x22F0640", VA = "0x1822F1A40")]
		public ActivityItemNameView()
		{
		}

		// Token: 0x04038880 RID: 231552
		[Token(Token = "0x4038880")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _itemId;

		// Token: 0x04038881 RID: 231553
		[Token(Token = "0x4038881")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x04038882 RID: 231554
		[Token(Token = "0x4038882")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04038883 RID: 231555
		[Token(Token = "0x4038883")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyCoinName;

		// Token: 0x04038884 RID: 231556
		[Token(Token = "0x4038884")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

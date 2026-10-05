using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200798C RID: 31116
	[Token(Token = "0x200798C")]
	public class Act1ArcadeGameObjectSwitchComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BA90 RID: 178832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA90")]
		[Address(RVA = "0x277DAC0", Offset = "0x277C6C0", VA = "0x18277DAC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BA91 RID: 178833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA91")]
		[Address(RVA = "0x277D6B0", Offset = "0x277C2B0", VA = "0x18277D6B0")]
		public void SwitchByIndex(int index, Act1ArcadeGameObjectSwitchComp.OutOfRangeLogicType outOfRangeLogicType = Act1ArcadeGameObjectSwitchComp.OutOfRangeLogicType.Return)
		{
		}

		// Token: 0x0602BA92 RID: 178834 RVA: 0x000DCC98 File Offset: 0x000DAE98
		[Token(Token = "0x602BA92")]
		[Address(RVA = "0x277D9D0", Offset = "0x277C5D0", VA = "0x18277D9D0")]
		private bool _HandleIndex(int index, Act1ArcadeGameObjectSwitchComp.OutOfRangeLogicType outOfRangeLogicType, out int newIndex)
		{
			return default(bool);
		}

		// Token: 0x0602BA93 RID: 178835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA93")]
		[Address(RVA = "0x277D5F0", Offset = "0x277C1F0", VA = "0x18277D5F0")]
		public void HideAll()
		{
		}

		// Token: 0x0602BA94 RID: 178836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA94")]
		[Address(RVA = "0x277DBC0", Offset = "0x277C7C0", VA = "0x18277DBC0")]
		public Act1ArcadeGameObjectSwitchComp()
		{
		}

		// Token: 0x0403F280 RID: 258688
		[Token(Token = "0x403F280")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _objects;

		// Token: 0x0403F281 RID: 258689
		[Token(Token = "0x403F281")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_catchedGo;

		// Token: 0x0403F282 RID: 258690
		[Token(Token = "0x403F282")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403F283 RID: 258691
		[Token(Token = "0x403F283")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F284 RID: 258692
		[Token(Token = "0x403F284")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SwitchByIndex;

		// Token: 0x0403F285 RID: 258693
		[Token(Token = "0x403F285")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleIndex;

		// Token: 0x0403F286 RID: 258694
		[Token(Token = "0x403F286")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideAll;

		// Token: 0x0403F287 RID: 258695
		[Token(Token = "0x403F287")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200798D RID: 31117
		[Token(Token = "0x200798D")]
		public enum OutOfRangeLogicType
		{
			// Token: 0x0403F289 RID: 258697
			[Token(Token = "0x403F289")]
			Return,
			// Token: 0x0403F28A RID: 258698
			[Token(Token = "0x403F28A")]
			Clamp
		}
	}
}

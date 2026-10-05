using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E36 RID: 15926
	[Token(Token = "0x2003E36")]
	public class SquadListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018C01 RID: 101377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C01")]
		[Address(RVA = "0x117F4B0", Offset = "0x117E0B0", VA = "0x18117F4B0")]
		public void ApplyData(SquadFriendData data, [Optional] string alias)
		{
		}

		// Token: 0x06018C02 RID: 101378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C02")]
		[Address(RVA = "0x117F690", Offset = "0x117E290", VA = "0x18117F690")]
		public void OnClick()
		{
		}

		// Token: 0x06018C03 RID: 101379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C03")]
		[Address(RVA = "0x117F7C0", Offset = "0x117E3C0", VA = "0x18117F7C0")]
		public SquadListItem()
		{
		}

		// Token: 0x0401E681 RID: 124545
		[Token(Token = "0x401E681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SquadSharedCharHeadIcon _charView;

		// Token: 0x0401E682 RID: 124546
		[Token(Token = "0x401E682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _headImage;

		// Token: 0x0401E683 RID: 124547
		[Token(Token = "0x401E683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _friendName;

		// Token: 0x0401E684 RID: 124548
		[Token(Token = "0x401E684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _friendLvl;

		// Token: 0x0401E685 RID: 124549
		[Token(Token = "0x401E685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _serverName;

		// Token: 0x0401E686 RID: 124550
		[Token(Token = "0x401E686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _aliasName;

		// Token: 0x0401E687 RID: 124551
		[Token(Token = "0x401E687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Animator _aliasAnim;

		// Token: 0x0401E688 RID: 124552
		[Token(Token = "0x401E688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SquadFriendData m_cacheData;

		// Token: 0x0401E689 RID: 124553
		[Token(Token = "0x401E689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0401E68A RID: 124554
		[Token(Token = "0x401E68A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401E68B RID: 124555
		[Token(Token = "0x401E68B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

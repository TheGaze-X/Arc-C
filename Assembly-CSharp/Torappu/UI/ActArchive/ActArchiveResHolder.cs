using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD9 RID: 27353
	[Token(Token = "0x2006AD9")]
	public class ActArchiveResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x060271FF RID: 160255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C7B")]
		public Sprite bkg
		{
			[Token(Token = "0x60271FF")]
			[Address(RVA = "0x224DAD0", Offset = "0x224C6D0", VA = "0x18224DAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027200 RID: 160256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027200")]
		public T GetHolderComponent<T>() where T : IActArchiveSubResHolder
		{
			return null;
		}

		// Token: 0x06027201 RID: 160257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027201")]
		[Address(RVA = "0x224D7B0", Offset = "0x224C3B0", VA = "0x18224D7B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027202 RID: 160258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027202")]
		[Address(RVA = "0x224DA40", Offset = "0x224C640", VA = "0x18224DA40")]
		public ActArchiveResHolder()
		{
		}

		// Token: 0x0403756E RID: 226670
		[Token(Token = "0x403756E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _subResHolders;

		// Token: 0x0403756F RID: 226671
		[Token(Token = "0x403756F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Background Image")]
		private Sprite _bkg;

		// Token: 0x04037570 RID: 226672
		[Token(Token = "0x4037570")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, IActArchiveSubResHolder> m_subResHolders;

		// Token: 0x04037571 RID: 226673
		[Token(Token = "0x4037571")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bkg;

		// Token: 0x04037572 RID: 226674
		[Token(Token = "0x4037572")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHolderComponent;

		// Token: 0x04037573 RID: 226675
		[Token(Token = "0x4037573")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037574 RID: 226676
		[Token(Token = "0x4037574")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

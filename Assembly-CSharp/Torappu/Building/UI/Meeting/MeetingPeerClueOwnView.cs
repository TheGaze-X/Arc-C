using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D76 RID: 7542
	[Token(Token = "0x2001D76")]
	public class MeetingPeerClueOwnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x00045B40 File Offset: 0x00043D40
		[Token(Token = "0x1700169A")]
		public int category
		{
			[Token(Token = "0x600BA49")]
			[Address(RVA = "0x337EB70", Offset = "0x337D770", VA = "0x18337EB70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4A")]
		[Address(RVA = "0x337E990", Offset = "0x337D590", VA = "0x18337E990")]
		private void Awake()
		{
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4B")]
		[Address(RVA = "0x337EA30", Offset = "0x337D630", VA = "0x18337EA30")]
		public void Setup(bool peerOwnClue, bool selfOwnClue, bool hasSentClue)
		{
		}

		// Token: 0x0600BA4C RID: 47692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4C")]
		[Address(RVA = "0x337EB10", Offset = "0x337D710", VA = "0x18337EB10")]
		public MeetingPeerClueOwnView()
		{
		}

		// Token: 0x0400B938 RID: 47416
		[Token(Token = "0x400B938")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int _category;

		// Token: 0x0400B939 RID: 47417
		[Token(Token = "0x400B939")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Text _numberLabel;

		// Token: 0x0400B93A RID: 47418
		[Token(Token = "0x400B93A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public GameObject _ownPanel;

		// Token: 0x0400B93B RID: 47419
		[Token(Token = "0x400B93B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public GameObject _canHelpPanel;

		// Token: 0x0400B93C RID: 47420
		[Token(Token = "0x400B93C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public GameObject _canNotHelpPanel;

		// Token: 0x0400B93D RID: 47421
		[Token(Token = "0x400B93D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _hasSentClue;

		// Token: 0x0400B93E RID: 47422
		[Token(Token = "0x400B93E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x0400B93F RID: 47423
		[Token(Token = "0x400B93F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400B940 RID: 47424
		[Token(Token = "0x400B940")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B941 RID: 47425
		[Token(Token = "0x400B941")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D67 RID: 7527
	[Token(Token = "0x2001D67")]
	public class MeetingClueItemView : MonoBehaviour
	{
		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600B9E5 RID: 47589 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9E6 RID: 47590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000060")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueClicked
		{
			[Token(Token = "0x600B9E5")]
			[Address(RVA = "0x3379460", Offset = "0x3378060", VA = "0x183379460")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9E6")]
			[Address(RVA = "0x3379670", Offset = "0x3378270", VA = "0x183379670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x0600B9E7 RID: 47591 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9E8 RID: 47592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000061")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueRemoveClicked
		{
			[Token(Token = "0x600B9E7")]
			[Address(RVA = "0x3379510", Offset = "0x3378110", VA = "0x183379510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9E8")]
			[Address(RVA = "0x3379720", Offset = "0x3378320", VA = "0x183379720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x0600B9E9 RID: 47593 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9EA RID: 47594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000062")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueUnequipClicked
		{
			[Token(Token = "0x600B9E9")]
			[Address(RVA = "0x33795C0", Offset = "0x33781C0", VA = "0x1833795C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9EA")]
			[Address(RVA = "0x33797D0", Offset = "0x33783D0", VA = "0x1833797D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EB")]
		[Address(RVA = "0x3378EE0", Offset = "0x3377AE0", VA = "0x183378EE0")]
		public void Setup(IMeetingClue clue, bool showBonusLabel, bool showRemoveButton, bool selected = false, int overrideBonus = -1)
		{
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EC")]
		[Address(RVA = "0x33793A0", Offset = "0x3377FA0", VA = "0x1833793A0")]
		private void _RefreshRestTime()
		{
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9ED")]
		[Address(RVA = "0x3378E30", Offset = "0x3377A30", VA = "0x183378E30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EE")]
		[Address(RVA = "0x3378E80", Offset = "0x3377A80", VA = "0x183378E80")]
		public void OnPressed()
		{
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EF")]
		[Address(RVA = "0x3378EA0", Offset = "0x3377AA0", VA = "0x183378EA0")]
		public void OnRemovePressed()
		{
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F0")]
		[Address(RVA = "0x3378EC0", Offset = "0x3377AC0", VA = "0x183378EC0")]
		public void OnUnequipPressed()
		{
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueItemView()
		{
		}

		// Token: 0x0400B8AE RID: 47278
		[Token(Token = "0x400B8AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0400B8AF RID: 47279
		[Token(Token = "0x400B8AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _originLabel;

		// Token: 0x0400B8B0 RID: 47280
		[Token(Token = "0x400B8B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _bonusLabel;

		// Token: 0x0400B8B1 RID: 47281
		[Token(Token = "0x400B8B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bonusLabelRoot;

		// Token: 0x0400B8B2 RID: 47282
		[Token(Token = "0x400B8B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _removeButtonRoot;

		// Token: 0x0400B8B3 RID: 47283
		[Token(Token = "0x400B8B3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MeetingClueRestTimeLabel _restTimeLabel;

		// Token: 0x0400B8B4 RID: 47284
		[Token(Token = "0x400B8B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _clueImage;

		// Token: 0x0400B8B5 RID: 47285
		[Token(Token = "0x400B8B5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MeetingClueProducerView[] _producerViews;

		// Token: 0x0400B8B6 RID: 47286
		[Token(Token = "0x400B8B6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _inSlotPanel;

		// Token: 0x0400B8B7 RID: 47287
		[Token(Token = "0x400B8B7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _selectPanel;

		// Token: 0x0400B8B8 RID: 47288
		[Token(Token = "0x400B8B8")]
		[FieldOffset(Offset = "0x68")]
		private IMeetingClue m_clue;
	}
}

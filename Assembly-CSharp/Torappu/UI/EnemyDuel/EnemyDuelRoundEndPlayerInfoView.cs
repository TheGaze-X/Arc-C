using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005010 RID: 20496
	[Token(Token = "0x2005010")]
	public class EnemyDuelRoundEndPlayerInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E69D RID: 124573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E69D")]
		[Address(RVA = "0x181F660", Offset = "0x181E260", VA = "0x18181F660")]
		public void Render(bool isWin, EnemyDuelRoundEndViewModel.PlayerInfo playerInfo)
		{
		}

		// Token: 0x0601E69E RID: 124574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E69E")]
		[Address(RVA = "0x181F8A0", Offset = "0x181E4A0", VA = "0x18181F8A0")]
		public EnemyDuelRoundEndPlayerInfoView()
		{
		}

		// Token: 0x04028AFE RID: 166654
		[Token(Token = "0x4028AFE")]
		private const string NICK_ID_FORMAT = "#{0}";

		// Token: 0x04028AFF RID: 166655
		[Token(Token = "0x4028AFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x04028B00 RID: 166656
		[Token(Token = "0x4028B00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04028B01 RID: 166657
		[Token(Token = "0x4028B01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameWin;

		// Token: 0x04028B02 RID: 166658
		[Token(Token = "0x4028B02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nickIdWin;

		// Token: 0x04028B03 RID: 166659
		[Token(Token = "0x4028B03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nameLose;

		// Token: 0x04028B04 RID: 166660
		[Token(Token = "0x4028B04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _nickIdLose;

		// Token: 0x04028B05 RID: 166661
		[Token(Token = "0x4028B05")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028B06 RID: 166662
		[Token(Token = "0x4028B06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028B07 RID: 166663
		[Token(Token = "0x4028B07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB2 RID: 31410
	[Token(Token = "0x2007AB2")]
	public class Act12sideMilestoneView : DataBinder<Act12sideMilestoneProperty>
	{
		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x0602BFF9 RID: 180217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFFA RID: 180218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700671F")]
		public Action<Act12SideData.PhotoInfo> onPhotoCallback
		{
			[Token(Token = "0x602BFF9")]
			[Address(RVA = "0x27DEE70", Offset = "0x27DDA70", VA = "0x1827DEE70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFFA")]
			[Address(RVA = "0x27DEFD0", Offset = "0x27DDBD0", VA = "0x1827DEFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x0602BFFB RID: 180219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFFC RID: 180220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006720")]
		public Action<string> onMilestoneCallBack
		{
			[Token(Token = "0x602BFFB")]
			[Address(RVA = "0x27DEE10", Offset = "0x27DDA10", VA = "0x1827DEE10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFFC")]
			[Address(RVA = "0x27DEF50", Offset = "0x27DDB50", VA = "0x1827DEF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x0602BFFD RID: 180221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFFE RID: 180222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006721")]
		public Action onAllMilestoneCallBack
		{
			[Token(Token = "0x602BFFD")]
			[Address(RVA = "0x27DEDB0", Offset = "0x27DD9B0", VA = "0x1827DEDB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFFE")]
			[Address(RVA = "0x27DEED0", Offset = "0x27DDAD0", VA = "0x1827DEED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BFFF RID: 180223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFFF")]
		[Address(RVA = "0x27DE4C0", Offset = "0x27DD0C0", VA = "0x1827DE4C0")]
		public void Init(string actId)
		{
		}

		// Token: 0x0602C000 RID: 180224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C000")]
		[Address(RVA = "0x27DE770", Offset = "0x27DD370", VA = "0x1827DE770", Slot = "7")]
		public override void OnValueChanged(Act12sideMilestoneProperty property)
		{
		}

		// Token: 0x0602C001 RID: 180225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C001")]
		[Address(RVA = "0x27DEB10", Offset = "0x27DD710", VA = "0x1827DEB10")]
		public void UpdatePhotoWall()
		{
		}

		// Token: 0x0602C002 RID: 180226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C002")]
		[Address(RVA = "0x27DE650", Offset = "0x27DD250", VA = "0x1827DE650")]
		public void OnPhotoClick(Act12SideData.PhotoInfo photInfo)
		{
		}

		// Token: 0x0602C003 RID: 180227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C003")]
		[Address(RVA = "0x27DECA0", Offset = "0x27DD8A0", VA = "0x1827DECA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C004 RID: 180228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C004")]
		[Address(RVA = "0x27DE540", Offset = "0x27DD140", VA = "0x1827DE540")]
		public void OnBtnRewardAllClick()
		{
		}

		// Token: 0x0602C005 RID: 180229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C005")]
		[Address(RVA = "0x27DED40", Offset = "0x27DD940", VA = "0x1827DED40")]
		public Act12sideMilestoneView()
		{
		}

		// Token: 0x0403FBE1 RID: 261089
		[Token(Token = "0x403FBE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12sideMilestoneListAdapter _listAdapter;

		// Token: 0x0403FBE2 RID: 261090
		[Token(Token = "0x403FBE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403FBE3 RID: 261091
		[Token(Token = "0x403FBE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCompletion;

		// Token: 0x0403FBE4 RID: 261092
		[Token(Token = "0x403FBE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnGetReward;

		// Token: 0x0403FBE5 RID: 261093
		[Token(Token = "0x403FBE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act12sidePhotoWallItemView[] _photoList;

		// Token: 0x0403FBE6 RID: 261094
		[Token(Token = "0x403FBE6")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403FBE7 RID: 261095
		[Token(Token = "0x403FBE7")]
		[FieldOffset(Offset = "0x50")]
		private string m_actId;

		// Token: 0x0403FBE8 RID: 261096
		[Token(Token = "0x403FBE8")]
		[FieldOffset(Offset = "0x58")]
		private AudioClickPlayer m_btnGetRewardAudio;

		// Token: 0x0403FBEC RID: 261100
		[Token(Token = "0x403FBEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPhotoCallback;

		// Token: 0x0403FBED RID: 261101
		[Token(Token = "0x403FBED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPhotoCallback;

		// Token: 0x0403FBEE RID: 261102
		[Token(Token = "0x403FBEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onMilestoneCallBack;

		// Token: 0x0403FBEF RID: 261103
		[Token(Token = "0x403FBEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onMilestoneCallBack;

		// Token: 0x0403FBF0 RID: 261104
		[Token(Token = "0x403FBF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onAllMilestoneCallBack;

		// Token: 0x0403FBF1 RID: 261105
		[Token(Token = "0x403FBF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onAllMilestoneCallBack;

		// Token: 0x0403FBF2 RID: 261106
		[Token(Token = "0x403FBF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FBF3 RID: 261107
		[Token(Token = "0x403FBF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FBF4 RID: 261108
		[Token(Token = "0x403FBF4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdatePhotoWall;

		// Token: 0x0403FBF5 RID: 261109
		[Token(Token = "0x403FBF5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPhotoClick;

		// Token: 0x0403FBF6 RID: 261110
		[Token(Token = "0x403FBF6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FBF7 RID: 261111
		[Token(Token = "0x403FBF7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnRewardAllClick;

		// Token: 0x0403FBF8 RID: 261112
		[Token(Token = "0x403FBF8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007ABB RID: 31419
	[Token(Token = "0x2007ABB")]
	public class Act12sidePhotoWallItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x0602C01D RID: 180253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C01E RID: 180254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006723")]
		public Action<Act12SideData.PhotoInfo> onClickAction
		{
			[Token(Token = "0x602C01D")]
			[Address(RVA = "0x27FF3D0", Offset = "0x27FDFD0", VA = "0x1827FF3D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602C01E")]
			[Address(RVA = "0x27FF430", Offset = "0x27FE030", VA = "0x1827FF430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C01F RID: 180255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C01F")]
		[Address(RVA = "0x27FEF60", Offset = "0x27FDB60", VA = "0x1827FEF60")]
		public void UpdateState(string actId)
		{
		}

		// Token: 0x0602C020 RID: 180256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C020")]
		[Address(RVA = "0x27FEE90", Offset = "0x27FDA90", VA = "0x1827FEE90")]
		public void OnPhotoClick()
		{
		}

		// Token: 0x0602C021 RID: 180257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C021")]
		[Address(RVA = "0x27FEDB0", Offset = "0x27FD9B0", VA = "0x1827FEDB0")]
		public void OnLockClick()
		{
		}

		// Token: 0x0602C022 RID: 180258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C022")]
		[Address(RVA = "0x27FF120", Offset = "0x27FDD20", VA = "0x1827FF120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C023 RID: 180259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C023")]
		[Address(RVA = "0x27FF370", Offset = "0x27FDF70", VA = "0x1827FF370")]
		public Act12sidePhotoWallItemView()
		{
		}

		// Token: 0x0403FC39 RID: 261177
		[Token(Token = "0x403FC39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _photoId;

		// Token: 0x0403FC3A RID: 261178
		[Token(Token = "0x403FC3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textUnlockCount;

		// Token: 0x0403FC3B RID: 261179
		[Token(Token = "0x403FC3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _stateToggle;

		// Token: 0x0403FC3C RID: 261180
		[Token(Token = "0x403FC3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _trackPointGo;

		// Token: 0x0403FC3E RID: 261182
		[Token(Token = "0x403FC3E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403FC3F RID: 261183
		[Token(Token = "0x403FC3F")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0403FC40 RID: 261184
		[Token(Token = "0x403FC40")]
		[FieldOffset(Offset = "0x50")]
		private Act12SideData.PhotoInfo m_photoData;

		// Token: 0x0403FC41 RID: 261185
		[Token(Token = "0x403FC41")]
		[FieldOffset(Offset = "0x58")]
		private Act12SideData.MileStoneInfo m_milestoneData;

		// Token: 0x0403FC42 RID: 261186
		[Token(Token = "0x403FC42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickAction;

		// Token: 0x0403FC43 RID: 261187
		[Token(Token = "0x403FC43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickAction;

		// Token: 0x0403FC44 RID: 261188
		[Token(Token = "0x403FC44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FC45 RID: 261189
		[Token(Token = "0x403FC45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPhotoClick;

		// Token: 0x0403FC46 RID: 261190
		[Token(Token = "0x403FC46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLockClick;

		// Token: 0x0403FC47 RID: 261191
		[Token(Token = "0x403FC47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FC48 RID: 261192
		[Token(Token = "0x403FC48")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

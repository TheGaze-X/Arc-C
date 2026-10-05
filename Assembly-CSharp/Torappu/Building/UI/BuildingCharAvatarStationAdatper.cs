using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B36 RID: 6966
	[Token(Token = "0x2001B36")]
	public class BuildingCharAvatarStationAdatper
	{
		// Token: 0x0600AF5A RID: 44890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5A")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public BuildingCharAvatarStationAdatper(BuildingCharAvatarStationAdatper.IProvider provider)
		{
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5B")]
		[Address(RVA = "0x32A1CB0", Offset = "0x32A08B0", VA = "0x1832A1CB0")]
		public void Render()
		{
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5C")]
		[Address(RVA = "0x32A1F70", Offset = "0x32A0B70", VA = "0x1832A1F70")]
		private void _OnCharClicked(BuildingCharModel charModel, object index)
		{
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5D")]
		[Address(RVA = "0x32A20C0", Offset = "0x32A0CC0", VA = "0x1832A20C0")]
		private void _OnLockedSlotClicked(object index)
		{
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5E")]
		[Address(RVA = "0x32A22E0", Offset = "0x32A0EE0", VA = "0x1832A22E0")]
		private void _RegisterFirstEmptySlotToAVG()
		{
		}

		// Token: 0x0400A8EB RID: 43243
		[Token(Token = "0x400A8EB")]
		[FieldOffset(Offset = "0x10")]
		private BuildingCharAvatarStationAdatper.IProvider m_provider;

		// Token: 0x0400A8EC RID: 43244
		[Token(Token = "0x400A8EC")]
		[FieldOffset(Offset = "0x18")]
		private BuildingCharModel[] m_chars;

		// Token: 0x0400A8ED RID: 43245
		[Token(Token = "0x400A8ED")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0400A8EE RID: 43246
		[Token(Token = "0x400A8EE")]
		[FieldOffset(Offset = "0x28")]
		private BuildingCharAvatarStationAdatper.CharListAdapter m_listAdapter;

		// Token: 0x02001B37 RID: 6967
		[Token(Token = "0x2001B37")]
		public interface IProvider
		{
			// Token: 0x170014C8 RID: 5320
			// (get) Token: 0x0600AF5F RID: 44895
			[Token(Token = "0x170014C8")]
			int finalMaxCharNum { [Token(Token = "0x600AF5F")] get; }

			// Token: 0x170014C9 RID: 5321
			// (get) Token: 0x0600AF60 RID: 44896
			[Token(Token = "0x170014C9")]
			int curMaxCharNum { [Token(Token = "0x600AF60")] get; }

			// Token: 0x170014CA RID: 5322
			// (get) Token: 0x0600AF61 RID: 44897
			[Token(Token = "0x170014CA")]
			BuildingCharModel[] stationedChars { [Token(Token = "0x600AF61")] get; }

			// Token: 0x170014CB RID: 5323
			// (get) Token: 0x0600AF62 RID: 44898
			[Token(Token = "0x170014CB")]
			Action<BuildingCharModel, int> onCharClicked { [Token(Token = "0x600AF62")] get; }

			// Token: 0x170014CC RID: 5324
			// (get) Token: 0x0600AF63 RID: 44899
			[Token(Token = "0x170014CC")]
			SimpleLayoutContent avatarContainer { [Token(Token = "0x600AF63")] get; }

			// Token: 0x170014CD RID: 5325
			// (get) Token: 0x0600AF64 RID: 44900
			[Token(Token = "0x170014CD")]
			string slotId { [Token(Token = "0x600AF64")] get; }
		}

		// Token: 0x02001B38 RID: 6968
		[Token(Token = "0x2001B38")]
		private class CharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AF65 RID: 44901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF65")]
			[Address(RVA = "0x32AB6A0", Offset = "0x32AA2A0", VA = "0x1832AB6A0")]
			public CharListAdapter(BuildingCharAvatarStationAdatper closure)
			{
			}

			// Token: 0x170014CE RID: 5326
			// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x00043488 File Offset: 0x00041688
			[Token(Token = "0x170014CE")]
			public override int count
			{
				[Token(Token = "0x600AF66")]
				[Address(RVA = "0x32AB720", Offset = "0x32AA320", VA = "0x1832AB720", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AF67 RID: 44903 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF67")]
			[Address(RVA = "0x32AB1E0", Offset = "0x32A9DE0", VA = "0x1832AB1E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A8EF RID: 43247
			[Token(Token = "0x400A8EF")]
			[FieldOffset(Offset = "0x20")]
			private BuildingCharAvatarStationAdatper m_closure;

			// Token: 0x0400A8F0 RID: 43248
			[Token(Token = "0x400A8F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A8F1 RID: 43249
			[Token(Token = "0x400A8F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A8F2 RID: 43250
			[Token(Token = "0x400A8F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

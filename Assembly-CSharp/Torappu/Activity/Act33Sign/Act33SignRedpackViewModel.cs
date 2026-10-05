using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x02007486 RID: 29830
	[Token(Token = "0x2007486")]
	public class Act33SignRedpackViewModel : IHotfixable
	{
		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x0602A11D RID: 172317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A11E RID: 172318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700632D")]
		public string activityId
		{
			[Token(Token = "0x602A11D")]
			[Address(RVA = "0x25C1E40", Offset = "0x25C0A40", VA = "0x1825C1E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A11E")]
			[Address(RVA = "0x25C2080", Offset = "0x25C0C80", VA = "0x1825C2080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x0602A11F RID: 172319 RVA: 0x000D75E0 File Offset: 0x000D57E0
		[Token(Token = "0x1700632E")]
		public bool redpackAvailable
		{
			[Token(Token = "0x602A11F")]
			[Address(RVA = "0x25C1EA0", Offset = "0x25C0AA0", VA = "0x1825C1EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x0602A120 RID: 172320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700632F")]
		public List<Act33SignRedpackItemViewModel> redpackItemList
		{
			[Token(Token = "0x602A120")]
			[Address(RVA = "0x25C1F20", Offset = "0x25C0B20", VA = "0x1825C1F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x0602A121 RID: 172321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A122 RID: 172322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006330")]
		public Func<string, string, Sprite> LoadSpriteFromAutoPackHub
		{
			[Token(Token = "0x602A121")]
			[Address(RVA = "0x25C1D80", Offset = "0x25C0980", VA = "0x1825C1D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A122")]
			[Address(RVA = "0x25C1F80", Offset = "0x25C0B80", VA = "0x1825C1F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x0602A123 RID: 172323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A124 RID: 172324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006331")]
		public Action<int, string> RewardEvent
		{
			[Token(Token = "0x602A123")]
			[Address(RVA = "0x25C1DE0", Offset = "0x25C09E0", VA = "0x1825C1DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A124")]
			[Address(RVA = "0x25C2000", Offset = "0x25C0C00", VA = "0x1825C2000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A125 RID: 172325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A125")]
		[Address(RVA = "0x25C1B00", Offset = "0x25C0700", VA = "0x1825C1B00")]
		private Sprite _LoadSpriteForCurrentAct(string spriteId)
		{
			return null;
		}

		// Token: 0x0602A126 RID: 172326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A126")]
		[Address(RVA = "0x25C1800", Offset = "0x25C0400", VA = "0x1825C1800")]
		public void LoadData(int signCount, List<int> extraHistory, List<DefaultCheckInData.ExtraCheckinDailyInfo> extraCheckInInfos)
		{
		}

		// Token: 0x0602A127 RID: 172327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A127")]
		[Address(RVA = "0x25C1C80", Offset = "0x25C0880", VA = "0x1825C1C80")]
		public Act33SignRedpackViewModel()
		{
		}

		// Token: 0x0403C60B RID: 247307
		[Token(Token = "0x403C60B")]
		[FieldOffset(Offset = "0x10")]
		private List<Act33SignRedpackItemViewModel> m_itemViewModels;

		// Token: 0x0403C60C RID: 247308
		[Token(Token = "0x403C60C")]
		[FieldOffset(Offset = "0x18")]
		private Queue<Act33SignRedpackItemViewModel> m_redpackWaitForSign;

		// Token: 0x0403C610 RID: 247312
		[Token(Token = "0x403C610")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403C611 RID: 247313
		[Token(Token = "0x403C611")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403C612 RID: 247314
		[Token(Token = "0x403C612")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_redpackAvailable;

		// Token: 0x0403C613 RID: 247315
		[Token(Token = "0x403C613")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_redpackItemList;

		// Token: 0x0403C614 RID: 247316
		[Token(Token = "0x403C614")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_LoadSpriteFromAutoPackHub;

		// Token: 0x0403C615 RID: 247317
		[Token(Token = "0x403C615")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_LoadSpriteFromAutoPackHub;

		// Token: 0x0403C616 RID: 247318
		[Token(Token = "0x403C616")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_RewardEvent;

		// Token: 0x0403C617 RID: 247319
		[Token(Token = "0x403C617")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_RewardEvent;

		// Token: 0x0403C618 RID: 247320
		[Token(Token = "0x403C618")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSpriteForCurrentAct;

		// Token: 0x0403C619 RID: 247321
		[Token(Token = "0x403C619")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403C61A RID: 247322
		[Token(Token = "0x403C61A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

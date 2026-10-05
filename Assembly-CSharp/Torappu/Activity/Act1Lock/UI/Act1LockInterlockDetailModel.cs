using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078CB RID: 30923
	[Token(Token = "0x20078CB")]
	public class Act1LockInterlockDetailModel : Act1LockDetailModelBase
	{
		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x0602B5CF RID: 177615 RVA: 0x000DB8A0 File Offset: 0x000D9AA0
		[Token(Token = "0x1700657F")]
		public override ActivityInterlockData.InterlockStageType stageType
		{
			[Token(Token = "0x602B5CF")]
			[Address(RVA = "0x2724960", Offset = "0x2723560", VA = "0x182724960", Slot = "4")]
			get
			{
				return ActivityInterlockData.InterlockStageType.NONE;
			}
		}

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x0602B5D0 RID: 177616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006580")]
		public StageViewModel basicStageModel
		{
			[Token(Token = "0x602B5D0")]
			[Address(RVA = "0x2724840", Offset = "0x2723440", VA = "0x182724840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x0602B5D1 RID: 177617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006581")]
		public ActivityInterlockData.StageAdditionData additionData
		{
			[Token(Token = "0x602B5D1")]
			[Address(RVA = "0x2724780", Offset = "0x2723380", VA = "0x182724780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x0602B5D2 RID: 177618 RVA: 0x000DB8B8 File Offset: 0x000D9AB8
		// (set) Token: 0x0602B5D3 RID: 177619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006582")]
		public bool isExpand
		{
			[Token(Token = "0x602B5D2")]
			[Address(RVA = "0x2724900", Offset = "0x2723500", VA = "0x182724900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B5D3")]
			[Address(RVA = "0x2724BE0", Offset = "0x27237E0", VA = "0x182724BE0")]
			set
			{
			}
		}

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x0602B5D4 RID: 177620 RVA: 0x000DB8D0 File Offset: 0x000D9AD0
		[Token(Token = "0x17006583")]
		public bool useSpecialAssist
		{
			[Token(Token = "0x602B5D4")]
			[Address(RVA = "0x27249C0", Offset = "0x27235C0", VA = "0x1827249C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x0602B5D5 RID: 177621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006584")]
		public CharacterCardViewModel assistCharModel
		{
			[Token(Token = "0x602B5D5")]
			[Address(RVA = "0x27247E0", Offset = "0x27233E0", VA = "0x1827247E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x0602B5D6 RID: 177622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006585")]
		public List<CharacterCardViewModel> interlockCharList
		{
			[Token(Token = "0x602B5D6")]
			[Address(RVA = "0x27248A0", Offset = "0x27234A0", VA = "0x1827248A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B5D7 RID: 177623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5D7")]
		[Address(RVA = "0x27242E0", Offset = "0x2722EE0", VA = "0x1827242E0", Slot = "5")]
		public override void LoadStageData(string stageId)
		{
		}

		// Token: 0x0602B5D8 RID: 177624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5D8")]
		[Address(RVA = "0x27244F0", Offset = "0x27230F0", VA = "0x1827244F0")]
		public void UpdateInterlockList()
		{
		}

		// Token: 0x0602B5D9 RID: 177625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5D9")]
		[Address(RVA = "0x2724650", Offset = "0x2723250", VA = "0x182724650")]
		public Act1LockInterlockDetailModel()
		{
		}

		// Token: 0x0403EB53 RID: 256851
		[Token(Token = "0x403EB53")]
		[FieldOffset(Offset = "0x20")]
		private ActivityInterlockData.StageAdditionData m_additionData;

		// Token: 0x0403EB54 RID: 256852
		[Token(Token = "0x403EB54")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isExpand;

		// Token: 0x0403EB55 RID: 256853
		[Token(Token = "0x403EB55")]
		[FieldOffset(Offset = "0x30")]
		private StageViewModel m_commonStageModel;

		// Token: 0x0403EB56 RID: 256854
		[Token(Token = "0x403EB56")]
		[FieldOffset(Offset = "0x38")]
		private List<CharacterCardViewModel> m_interlockCharList;

		// Token: 0x0403EB57 RID: 256855
		[Token(Token = "0x403EB57")]
		[FieldOffset(Offset = "0x40")]
		private CharacterCardViewModel m_assistCharModel;

		// Token: 0x0403EB58 RID: 256856
		[Token(Token = "0x403EB58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageType;

		// Token: 0x0403EB59 RID: 256857
		[Token(Token = "0x403EB59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_basicStageModel;

		// Token: 0x0403EB5A RID: 256858
		[Token(Token = "0x403EB5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_additionData;

		// Token: 0x0403EB5B RID: 256859
		[Token(Token = "0x403EB5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isExpand;

		// Token: 0x0403EB5C RID: 256860
		[Token(Token = "0x403EB5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isExpand;

		// Token: 0x0403EB5D RID: 256861
		[Token(Token = "0x403EB5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useSpecialAssist;

		// Token: 0x0403EB5E RID: 256862
		[Token(Token = "0x403EB5E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_assistCharModel;

		// Token: 0x0403EB5F RID: 256863
		[Token(Token = "0x403EB5F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_interlockCharList;

		// Token: 0x0403EB60 RID: 256864
		[Token(Token = "0x403EB60")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403EB61 RID: 256865
		[Token(Token = "0x403EB61")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateInterlockList;

		// Token: 0x0403EB62 RID: 256866
		[Token(Token = "0x403EB62")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

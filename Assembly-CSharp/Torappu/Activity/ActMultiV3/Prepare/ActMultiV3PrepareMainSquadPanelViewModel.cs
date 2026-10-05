using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.Multiplayer.Servers;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007064 RID: 28772
	[Token(Token = "0x2007064")]
	public class ActMultiV3PrepareMainSquadPanelViewModel : IHotfixable
	{
		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x06028DCB RID: 167371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DCC RID: 167372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700609B")]
		public string activityId
		{
			[Token(Token = "0x6028DCB")]
			[Address(RVA = "0x2442C50", Offset = "0x2441850", VA = "0x182442C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DCC")]
			[Address(RVA = "0x2443250", Offset = "0x2441E50", VA = "0x182443250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x06028DCD RID: 167373 RVA: 0x000D34E8 File Offset: 0x000D16E8
		// (set) Token: 0x06028DCE RID: 167374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700609C")]
		public bool stepEnd
		{
			[Token(Token = "0x6028DCD")]
			[Address(RVA = "0x2443130", Offset = "0x2441D30", VA = "0x182443130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028DCE")]
			[Address(RVA = "0x2443800", Offset = "0x2442400", VA = "0x182443800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x06028DCF RID: 167375 RVA: 0x000D3500 File Offset: 0x000D1700
		// (set) Token: 0x06028DD0 RID: 167376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700609D")]
		public bool reverse
		{
			[Token(Token = "0x6028DCF")]
			[Address(RVA = "0x2442F50", Offset = "0x2441B50", VA = "0x182442F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028DD0")]
			[Address(RVA = "0x24435C0", Offset = "0x24421C0", VA = "0x1824435C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x06028DD1 RID: 167377 RVA: 0x000D3518 File Offset: 0x000D1718
		// (set) Token: 0x06028DD2 RID: 167378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700609E")]
		public bool playNoPickBanner
		{
			[Token(Token = "0x6028DD1")]
			[Address(RVA = "0x2442E90", Offset = "0x2441A90", VA = "0x182442E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028DD2")]
			[Address(RVA = "0x24434D0", Offset = "0x24420D0", VA = "0x1824434D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x06028DD3 RID: 167379 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DD4 RID: 167380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700609F")]
		public string pickStepName
		{
			[Token(Token = "0x6028DD3")]
			[Address(RVA = "0x2442E30", Offset = "0x2441A30", VA = "0x182442E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DD4")]
			[Address(RVA = "0x2443450", Offset = "0x2442050", VA = "0x182443450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x06028DD5 RID: 167381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DD6 RID: 167382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A0")]
		public List<ActMultiV3PrepareMainSmallCharCardModel> squad
		{
			[Token(Token = "0x6028DD5")]
			[Address(RVA = "0x24430D0", Offset = "0x2441CD0", VA = "0x1824430D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DD6")]
			[Address(RVA = "0x2443780", Offset = "0x2442380", VA = "0x182443780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x06028DD7 RID: 167383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DD8 RID: 167384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A1")]
		public List<ActMultiV3PrepareMainSquadPanelReserveCharCardModel> reserveList
		{
			[Token(Token = "0x6028DD7")]
			[Address(RVA = "0x2442EF0", Offset = "0x2441AF0", VA = "0x182442EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DD8")]
			[Address(RVA = "0x2443540", Offset = "0x2442140", VA = "0x182443540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x06028DD9 RID: 167385 RVA: 0x000D3530 File Offset: 0x000D1730
		// (set) Token: 0x06028DDA RID: 167386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A2")]
		public bool showReserveList
		{
			[Token(Token = "0x6028DD9")]
			[Address(RVA = "0x2442FB0", Offset = "0x2441BB0", VA = "0x182442FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028DDA")]
			[Address(RVA = "0x2443630", Offset = "0x2442230", VA = "0x182443630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x06028DDB RID: 167387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DDC RID: 167388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A3")]
		public ActMultiV3PrepareMainSquadPanelViewModel.SysAllocModel sysAllocModel
		{
			[Token(Token = "0x6028DDB")]
			[Address(RVA = "0x2443190", Offset = "0x2441D90", VA = "0x182443190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DDC")]
			[Address(RVA = "0x2443870", Offset = "0x2442470", VA = "0x182443870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x06028DDD RID: 167389 RVA: 0x000D3548 File Offset: 0x000D1748
		[Token(Token = "0x170060A4")]
		public ActMultiV3PrepareMainSquadProc currProc
		{
			[Token(Token = "0x6028DDD")]
			[Address(RVA = "0x2442CB0", Offset = "0x24418B0", VA = "0x182442CB0")]
			get
			{
				return ActMultiV3PrepareMainSquadProc.NONE;
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x06028DDE RID: 167390 RVA: 0x000D3560 File Offset: 0x000D1760
		// (set) Token: 0x06028DDF RID: 167391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A5")]
		public int squadCntMax
		{
			[Token(Token = "0x6028DDE")]
			[Address(RVA = "0x2443010", Offset = "0x2441C10", VA = "0x182443010")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028DDF")]
			[Address(RVA = "0x24436A0", Offset = "0x24422A0", VA = "0x1824436A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x06028DE0 RID: 167392 RVA: 0x000D3578 File Offset: 0x000D1778
		// (set) Token: 0x06028DE1 RID: 167393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A6")]
		public int squadCntMin
		{
			[Token(Token = "0x6028DE0")]
			[Address(RVA = "0x2443070", Offset = "0x2441C70", VA = "0x182443070")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028DE1")]
			[Address(RVA = "0x2443710", Offset = "0x2442310", VA = "0x182443710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x06028DE2 RID: 167394 RVA: 0x000D3590 File Offset: 0x000D1790
		// (set) Token: 0x06028DE3 RID: 167395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A7")]
		public int tempHelpSeq
		{
			[Token(Token = "0x6028DE2")]
			[Address(RVA = "0x24431F0", Offset = "0x2441DF0", VA = "0x1824431F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028DE3")]
			[Address(RVA = "0x24438F0", Offset = "0x24424F0", VA = "0x1824438F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x06028DE4 RID: 167396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DE5 RID: 167397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A8")]
		public ActMultiV3PrepareMainSmallCharCardModel emptySmallChar
		{
			[Token(Token = "0x6028DE4")]
			[Address(RVA = "0x2442D70", Offset = "0x2441970", VA = "0x182442D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DE5")]
			[Address(RVA = "0x2443350", Offset = "0x2441F50", VA = "0x182443350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x06028DE6 RID: 167398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DE7 RID: 167399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060A9")]
		public ActMultiV3PrepareMainCharCardModel emptySquadChar
		{
			[Token(Token = "0x6028DE6")]
			[Address(RVA = "0x2442DD0", Offset = "0x24419D0", VA = "0x182442DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DE7")]
			[Address(RVA = "0x24433D0", Offset = "0x2441FD0", VA = "0x1824433D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x06028DE8 RID: 167400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028DE9 RID: 167401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060AA")]
		public ActMultiV3PrepareMainSkillAndModuleCharCardModel emptySkillSelectChar
		{
			[Token(Token = "0x6028DE8")]
			[Address(RVA = "0x2442D10", Offset = "0x2441910", VA = "0x182442D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028DE9")]
			[Address(RVA = "0x24432D0", Offset = "0x2441ED0", VA = "0x1824432D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028DEA RID: 167402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DEA")]
		[Address(RVA = "0x243F060", Offset = "0x243DC60", VA = "0x18243F060")]
		public void LoadStableData(string actId)
		{
		}

		// Token: 0x06028DEB RID: 167403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DEB")]
		[Address(RVA = "0x243F4F0", Offset = "0x243E0F0", VA = "0x18243F4F0")]
		public void Reset()
		{
		}

		// Token: 0x06028DEC RID: 167404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DEC")]
		[Address(RVA = "0x243FC40", Offset = "0x243E840", VA = "0x18243FC40")]
		public void Update()
		{
		}

		// Token: 0x06028DED RID: 167405 RVA: 0x000D35A8 File Offset: 0x000D17A8
		[Token(Token = "0x6028DED")]
		[Address(RVA = "0x2441D20", Offset = "0x2440920", VA = "0x182441D20")]
		private int _GetMapSquadMax(ActMultiV3Data actData, int defaultNum)
		{
			return 0;
		}

		// Token: 0x06028DEE RID: 167406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DEE")]
		[Address(RVA = "0x2440BA0", Offset = "0x243F7A0", VA = "0x182440BA0")]
		private void _AddToReserveList(int instId, ActMultiV3PrepareMainSmallCharCardModel viewModel, bool showInReserve)
		{
		}

		// Token: 0x06028DEF RID: 167407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DEF")]
		private void _FillList<T>(IList<T> list, T item, int count)
		{
		}

		// Token: 0x06028DF0 RID: 167408 RVA: 0x000D35C0 File Offset: 0x000D17C0
		[Token(Token = "0x6028DF0")]
		[Address(RVA = "0x2441770", Offset = "0x2440370", VA = "0x182441770")]
		private int _FindPosInSquad(int instId)
		{
			return 0;
		}

		// Token: 0x06028DF1 RID: 167409 RVA: 0x000D35D8 File Offset: 0x000D17D8
		[Token(Token = "0x6028DF1")]
		[Address(RVA = "0x2440DB0", Offset = "0x243F9B0", VA = "0x182440DB0")]
		private bool _AddToSquad(ActMultiV3PrepareMainSmallCharCardModel smallChrModel, int pos)
		{
			return default(bool);
		}

		// Token: 0x06028DF2 RID: 167410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DF2")]
		[Address(RVA = "0x243EE90", Offset = "0x243DA90", VA = "0x18243EE90")]
		public void CheckReserveVisible()
		{
		}

		// Token: 0x06028DF3 RID: 167411 RVA: 0x000D35F0 File Offset: 0x000D17F0
		[Token(Token = "0x6028DF3")]
		[Address(RVA = "0x243F640", Offset = "0x243E240", VA = "0x18243F640")]
		public bool SetCharInSquad(int instId, bool inSquad)
		{
			return default(bool);
		}

		// Token: 0x06028DF4 RID: 167412 RVA: 0x000D3608 File Offset: 0x000D1808
		[Token(Token = "0x6028DF4")]
		[Address(RVA = "0x243EE10", Offset = "0x243DA10", VA = "0x18243EE10")]
		public bool CheckInSquad(int instId)
		{
			return default(bool);
		}

		// Token: 0x06028DF5 RID: 167413 RVA: 0x000D3620 File Offset: 0x000D1820
		[Token(Token = "0x6028DF5")]
		[Address(RVA = "0x243EF90", Offset = "0x243DB90", VA = "0x18243EF90")]
		public bool HasEmptyPos()
		{
			return default(bool);
		}

		// Token: 0x06028DF6 RID: 167414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DF6")]
		[Address(RVA = "0x2441EA0", Offset = "0x2440AA0", VA = "0x182441EA0")]
		private void _LoadSkillProcDataBySquad()
		{
		}

		// Token: 0x06028DF7 RID: 167415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DF7")]
		[Address(RVA = "0x243F920", Offset = "0x243E520", VA = "0x18243F920")]
		public void SetCharSkill(int instId, string skillId)
		{
		}

		// Token: 0x06028DF8 RID: 167416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DF8")]
		[Address(RVA = "0x243F580", Offset = "0x243E180", VA = "0x18243F580")]
		public void SetCharEquip(int instId, string equipId)
		{
		}

		// Token: 0x06028DF9 RID: 167417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DF9")]
		[Address(RVA = "0x243F9E0", Offset = "0x243E5E0", VA = "0x18243F9E0")]
		public void SwitchShowSkill()
		{
		}

		// Token: 0x06028DFA RID: 167418 RVA: 0x000D3638 File Offset: 0x000D1838
		[Token(Token = "0x6028DFA")]
		[Address(RVA = "0x24424D0", Offset = "0x24410D0", VA = "0x1824424D0")]
		private bool _TryFindSkillSelectModelByInstId(int instId, out ActMultiV3PrepareMainSkillAndModuleCharCardModel outModel)
		{
			return default(bool);
		}

		// Token: 0x06028DFB RID: 167419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DFB")]
		[Address(RVA = "0x2442170", Offset = "0x2440D70", VA = "0x182442170")]
		private void _SaveSquadSkillEquipInfo()
		{
		}

		// Token: 0x06028DFC RID: 167420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028DFC")]
		[Address(RVA = "0x243EF30", Offset = "0x243DB30", VA = "0x18243EF30")]
		public List<TeamSquadSlotParam> ConfirmSquadDataForSvr()
		{
			return null;
		}

		// Token: 0x06028DFD RID: 167421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028DFD")]
		[Address(RVA = "0x2441970", Offset = "0x2440570", VA = "0x182441970")]
		private List<TeamSquadSlotParam> _GenSvrSquadData(int excludeInstId = -1)
		{
			return null;
		}

		// Token: 0x06028DFE RID: 167422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DFE")]
		[Address(RVA = "0x24413D0", Offset = "0x243FFD0", VA = "0x1824413D0")]
		private void _FillSlot(ActMultiV3PrepareMainSmallCharCardModel chr, TeamSquadSlotParam slot)
		{
		}

		// Token: 0x06028DFF RID: 167423 RVA: 0x000D3650 File Offset: 0x000D1850
		[Token(Token = "0x6028DFF")]
		[Address(RVA = "0x243F000", Offset = "0x243DC00", VA = "0x18243F000")]
		public bool JumpToEnd()
		{
			return default(bool);
		}

		// Token: 0x06028E00 RID: 167424 RVA: 0x000D3668 File Offset: 0x000D1868
		[Token(Token = "0x6028E00")]
		[Address(RVA = "0x243FA40", Offset = "0x243E640", VA = "0x18243FA40")]
		public bool ToNextProc()
		{
			return default(bool);
		}

		// Token: 0x06028E01 RID: 167425 RVA: 0x000D3680 File Offset: 0x000D1880
		[Token(Token = "0x6028E01")]
		[Address(RVA = "0x243FB00", Offset = "0x243E700", VA = "0x18243FB00")]
		public bool ToPreProc()
		{
			return default(bool);
		}

		// Token: 0x06028E02 RID: 167426 RVA: 0x000D3698 File Offset: 0x000D1898
		[Token(Token = "0x6028E02")]
		[Address(RVA = "0x24423C0", Offset = "0x2440FC0", VA = "0x1824423C0")]
		private bool _SwitchProc(int offset)
		{
			return default(bool);
		}

		// Token: 0x06028E03 RID: 167427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E03")]
		[Address(RVA = "0x2442660", Offset = "0x2441260", VA = "0x182442660")]
		private void _UpdateCheck()
		{
		}

		// Token: 0x06028E04 RID: 167428 RVA: 0x000D36B0 File Offset: 0x000D18B0
		[Token(Token = "0x6028E04")]
		[Address(RVA = "0x2441030", Offset = "0x243FC30", VA = "0x182441030")]
		private ActMultiV3IdentityType _CheckCharType(TeamProtocol.STPlayerStatus player, int instId)
		{
			return ActMultiV3IdentityType.NONE;
		}

		// Token: 0x06028E05 RID: 167429 RVA: 0x000D36C8 File Offset: 0x000D18C8
		[Token(Token = "0x6028E05")]
		[Address(RVA = "0x2441130", Offset = "0x243FD30", VA = "0x182441130")]
		private int _CompareChar(ActMultiV3PrepareMainSquadPanelReserveCharCardModel a, ActMultiV3PrepareMainSquadPanelReserveCharCardModel b)
		{
			return 0;
		}

		// Token: 0x06028E06 RID: 167430 RVA: 0x000D36E0 File Offset: 0x000D18E0
		[Token(Token = "0x6028E06")]
		[Address(RVA = "0x2441C70", Offset = "0x2440870", VA = "0x182441C70")]
		private int _GetIdentityPrior(ActMultiV3IdentityType identityType)
		{
			return 0;
		}

		// Token: 0x06028E07 RID: 167431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E07")]
		[Address(RVA = "0x2442BE0", Offset = "0x24417E0", VA = "0x182442BE0")]
		public ActMultiV3PrepareMainSquadPanelViewModel()
		{
		}

		// Token: 0x0403A49C RID: 238748
		[Token(Token = "0x403A49C")]
		[FieldOffset(Offset = "0x58")]
		public ActMultiV3PrepareMainSquadPanelViewModel.SkillModel skillEquipModel;

		// Token: 0x0403A49D RID: 238749
		[Token(Token = "0x403A49D")]
		[FieldOffset(Offset = "0x68")]
		public ActMultiV3PrepareMainSquadPanelViewModel.CheckModel checkModel;

		// Token: 0x0403A4A1 RID: 238753
		[Token(Token = "0x403A4A1")]
		public const int SQUAD_COUNT_MAX = 10;

		// Token: 0x0403A4A2 RID: 238754
		[Token(Token = "0x403A4A2")]
		public const int SQUAD_COUNT_MIN = 6;

		// Token: 0x0403A4A3 RID: 238755
		[Token(Token = "0x403A4A3")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3PrepareMainSquadProc m_currProc;

		// Token: 0x0403A4A4 RID: 238756
		[Token(Token = "0x403A4A4")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<int, ActMultiV3PrepareMainSmallCharCardModel> m_modelDict;

		// Token: 0x0403A4A5 RID: 238757
		[Token(Token = "0x403A4A5")]
		[FieldOffset(Offset = "0xA0")]
		private List<TeamSquadSlotParam> m_squadForSvr;

		// Token: 0x0403A4A6 RID: 238758
		[Token(Token = "0x403A4A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403A4A7 RID: 238759
		[Token(Token = "0x403A4A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403A4A8 RID: 238760
		[Token(Token = "0x403A4A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stepEnd;

		// Token: 0x0403A4A9 RID: 238761
		[Token(Token = "0x403A4A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_stepEnd;

		// Token: 0x0403A4AA RID: 238762
		[Token(Token = "0x403A4AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_reverse;

		// Token: 0x0403A4AB RID: 238763
		[Token(Token = "0x403A4AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_reverse;

		// Token: 0x0403A4AC RID: 238764
		[Token(Token = "0x403A4AC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playNoPickBanner;

		// Token: 0x0403A4AD RID: 238765
		[Token(Token = "0x403A4AD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_playNoPickBanner;

		// Token: 0x0403A4AE RID: 238766
		[Token(Token = "0x403A4AE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_pickStepName;

		// Token: 0x0403A4AF RID: 238767
		[Token(Token = "0x403A4AF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_pickStepName;

		// Token: 0x0403A4B0 RID: 238768
		[Token(Token = "0x403A4B0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_squad;

		// Token: 0x0403A4B1 RID: 238769
		[Token(Token = "0x403A4B1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_squad;

		// Token: 0x0403A4B2 RID: 238770
		[Token(Token = "0x403A4B2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_reserveList;

		// Token: 0x0403A4B3 RID: 238771
		[Token(Token = "0x403A4B3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_reserveList;

		// Token: 0x0403A4B4 RID: 238772
		[Token(Token = "0x403A4B4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_showReserveList;

		// Token: 0x0403A4B5 RID: 238773
		[Token(Token = "0x403A4B5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_showReserveList;

		// Token: 0x0403A4B6 RID: 238774
		[Token(Token = "0x403A4B6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_sysAllocModel;

		// Token: 0x0403A4B7 RID: 238775
		[Token(Token = "0x403A4B7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_sysAllocModel;

		// Token: 0x0403A4B8 RID: 238776
		[Token(Token = "0x403A4B8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_currProc;

		// Token: 0x0403A4B9 RID: 238777
		[Token(Token = "0x403A4B9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_squadCntMax;

		// Token: 0x0403A4BA RID: 238778
		[Token(Token = "0x403A4BA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_squadCntMax;

		// Token: 0x0403A4BB RID: 238779
		[Token(Token = "0x403A4BB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_squadCntMin;

		// Token: 0x0403A4BC RID: 238780
		[Token(Token = "0x403A4BC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_squadCntMin;

		// Token: 0x0403A4BD RID: 238781
		[Token(Token = "0x403A4BD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_tempHelpSeq;

		// Token: 0x0403A4BE RID: 238782
		[Token(Token = "0x403A4BE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_tempHelpSeq;

		// Token: 0x0403A4BF RID: 238783
		[Token(Token = "0x403A4BF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_emptySmallChar;

		// Token: 0x0403A4C0 RID: 238784
		[Token(Token = "0x403A4C0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_emptySmallChar;

		// Token: 0x0403A4C1 RID: 238785
		[Token(Token = "0x403A4C1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_emptySquadChar;

		// Token: 0x0403A4C2 RID: 238786
		[Token(Token = "0x403A4C2")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_emptySquadChar;

		// Token: 0x0403A4C3 RID: 238787
		[Token(Token = "0x403A4C3")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_emptySkillSelectChar;

		// Token: 0x0403A4C4 RID: 238788
		[Token(Token = "0x403A4C4")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_emptySkillSelectChar;

		// Token: 0x0403A4C5 RID: 238789
		[Token(Token = "0x403A4C5")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadStableData;

		// Token: 0x0403A4C6 RID: 238790
		[Token(Token = "0x403A4C6")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0403A4C7 RID: 238791
		[Token(Token = "0x403A4C7")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403A4C8 RID: 238792
		[Token(Token = "0x403A4C8")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GetMapSquadMax;

		// Token: 0x0403A4C9 RID: 238793
		[Token(Token = "0x403A4C9")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__AddToReserveList;

		// Token: 0x0403A4CA RID: 238794
		[Token(Token = "0x403A4CA")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FillList;

		// Token: 0x0403A4CB RID: 238795
		[Token(Token = "0x403A4CB")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__FindPosInSquad;

		// Token: 0x0403A4CC RID: 238796
		[Token(Token = "0x403A4CC")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__AddToSquad;

		// Token: 0x0403A4CD RID: 238797
		[Token(Token = "0x403A4CD")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckReserveVisible;

		// Token: 0x0403A4CE RID: 238798
		[Token(Token = "0x403A4CE")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_SetCharInSquad;

		// Token: 0x0403A4CF RID: 238799
		[Token(Token = "0x403A4CF")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckInSquad;

		// Token: 0x0403A4D0 RID: 238800
		[Token(Token = "0x403A4D0")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_HasEmptyPos;

		// Token: 0x0403A4D1 RID: 238801
		[Token(Token = "0x403A4D1")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__LoadSkillProcDataBySquad;

		// Token: 0x0403A4D2 RID: 238802
		[Token(Token = "0x403A4D2")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SetCharSkill;

		// Token: 0x0403A4D3 RID: 238803
		[Token(Token = "0x403A4D3")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_SetCharEquip;

		// Token: 0x0403A4D4 RID: 238804
		[Token(Token = "0x403A4D4")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SwitchShowSkill;

		// Token: 0x0403A4D5 RID: 238805
		[Token(Token = "0x403A4D5")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__TryFindSkillSelectModelByInstId;

		// Token: 0x0403A4D6 RID: 238806
		[Token(Token = "0x403A4D6")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__SaveSquadSkillEquipInfo;

		// Token: 0x0403A4D7 RID: 238807
		[Token(Token = "0x403A4D7")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ConfirmSquadDataForSvr;

		// Token: 0x0403A4D8 RID: 238808
		[Token(Token = "0x403A4D8")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GenSvrSquadData;

		// Token: 0x0403A4D9 RID: 238809
		[Token(Token = "0x403A4D9")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__FillSlot;

		// Token: 0x0403A4DA RID: 238810
		[Token(Token = "0x403A4DA")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_JumpToEnd;

		// Token: 0x0403A4DB RID: 238811
		[Token(Token = "0x403A4DB")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ToNextProc;

		// Token: 0x0403A4DC RID: 238812
		[Token(Token = "0x403A4DC")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_ToPreProc;

		// Token: 0x0403A4DD RID: 238813
		[Token(Token = "0x403A4DD")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__SwitchProc;

		// Token: 0x0403A4DE RID: 238814
		[Token(Token = "0x403A4DE")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__UpdateCheck;

		// Token: 0x0403A4DF RID: 238815
		[Token(Token = "0x403A4DF")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__CheckCharType;

		// Token: 0x0403A4E0 RID: 238816
		[Token(Token = "0x403A4E0")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__CompareChar;

		// Token: 0x0403A4E1 RID: 238817
		[Token(Token = "0x403A4E1")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__GetIdentityPrior;

		// Token: 0x0403A4E2 RID: 238818
		[Token(Token = "0x403A4E2")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007065 RID: 28773
		[Token(Token = "0x2007065")]
		public struct SkillModel
		{
			// Token: 0x0403A4E3 RID: 238819
			[Token(Token = "0x403A4E3")]
			[FieldOffset(Offset = "0x0")]
			public List<ActMultiV3PrepareMainSkillAndModuleCharCardModel> squad;

			// Token: 0x0403A4E4 RID: 238820
			[Token(Token = "0x403A4E4")]
			[FieldOffset(Offset = "0x8")]
			public bool showSkill;

			// Token: 0x0403A4E5 RID: 238821
			[Token(Token = "0x403A4E5")]
			[FieldOffset(Offset = "0xC")]
			public int enterSkillProcSeqNum;
		}

		// Token: 0x02007066 RID: 28774
		[Token(Token = "0x2007066")]
		public struct CheckModel
		{
			// Token: 0x0403A4E6 RID: 238822
			[Token(Token = "0x403A4E6")]
			[FieldOffset(Offset = "0x0")]
			public ActMultiV3PrepareMainSquadPanelViewModel.CheckModel.Player myself;

			// Token: 0x0403A4E7 RID: 238823
			[Token(Token = "0x403A4E7")]
			[FieldOffset(Offset = "0x8")]
			public ActMultiV3PrepareMainSquadPanelViewModel.CheckModel.Player partner;

			// Token: 0x02007067 RID: 28775
			[Token(Token = "0x2007067")]
			public class Player
			{
				// Token: 0x06028E08 RID: 167432 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6028E08")]
				[Address(RVA = "0x2461E00", Offset = "0x2460A00", VA = "0x182461E00")]
				public Player(int squadCapacity)
				{
				}

				// Token: 0x0403A4E8 RID: 238824
				[Token(Token = "0x403A4E8")]
				[FieldOffset(Offset = "0x10")]
				public List<ActMultiV3PrepareMainCharCardModel> squad;

				// Token: 0x0403A4E9 RID: 238825
				[Token(Token = "0x403A4E9")]
				[FieldOffset(Offset = "0x18")]
				public bool isReady;
			}
		}

		// Token: 0x02007068 RID: 28776
		[Token(Token = "0x2007068")]
		public class SysAllocModel
		{
			// Token: 0x06028E09 RID: 167433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E09")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SysAllocModel()
			{
			}

			// Token: 0x0403A4EA RID: 238826
			[Token(Token = "0x403A4EA")]
			[FieldOffset(Offset = "0x10")]
			public List<ActMultiV3PrepareMainSmallCharCardModel> charList;
		}
	}
}

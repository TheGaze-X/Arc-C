using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.Effects;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x0200280B RID: 10251
	[Token(Token = "0x200280B")]
	public class DialogController : IHotfixable, Scheduler.IWavePlugin
	{
		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x060110B2 RID: 69810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002590")]
		public DirectAssetLoader assetLoader
		{
			[Token(Token = "0x60110B2")]
			[Address(RVA = "0x8F2AC0", Offset = "0x8F16C0", VA = "0x1808F2AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x060110B3 RID: 69811 RVA: 0x00068EF8 File Offset: 0x000670F8
		[Token(Token = "0x17002591")]
		public bool isPlaying
		{
			[Token(Token = "0x60110B3")]
			[Address(RVA = "0x8F2C90", Offset = "0x8F1890", VA = "0x1808F2C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x060110B4 RID: 69812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002592")]
		public BattleStoryTree storyTree
		{
			[Token(Token = "0x60110B4")]
			[Address(RVA = "0x8F2D00", Offset = "0x8F1900", VA = "0x1808F2D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060110B5 RID: 69813 RVA: 0x00068F10 File Offset: 0x00067110
		[Token(Token = "0x60110B5")]
		[Address(RVA = "0x8EBC50", Offset = "0x8EA850", VA = "0x1808EBC50")]
		public bool ExecuteCommandByIndex(ref int commandIndex, int decision, out Command command)
		{
			return default(bool);
		}

		// Token: 0x060110B6 RID: 69814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110B6")]
		[Address(RVA = "0x8F2200", Offset = "0x8F0E00", VA = "0x1808F2200")]
		private void _InitCommandDicIfNot()
		{
		}

		// Token: 0x060110B7 RID: 69815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110B7")]
		[Address(RVA = "0x8F18D0", Offset = "0x8F04D0", VA = "0x1808F18D0")]
		private Character _GetCharNpc(Command command)
		{
			return null;
		}

		// Token: 0x060110B8 RID: 69816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110B8")]
		[Address(RVA = "0x8F1D70", Offset = "0x8F0970", VA = "0x1808F1D70")]
		private Enemy _GetEnemyNpc(Command command)
		{
			return null;
		}

		// Token: 0x060110B9 RID: 69817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110B9")]
		[Address(RVA = "0x8F1A30", Offset = "0x8F0630", VA = "0x1808F1A30")]
		private Enemy _GetEnemyNpcByAlias(Command command)
		{
			return null;
		}

		// Token: 0x060110BA RID: 69818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110BA")]
		[Address(RVA = "0x8F1F10", Offset = "0x8F0B10", VA = "0x1808F1F10")]
		private Unit _GetNpc(Command command)
		{
			return null;
		}

		// Token: 0x060110BB RID: 69819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110BB")]
		[Address(RVA = "0x8F1FD0", Offset = "0x8F0BD0", VA = "0x1808F1FD0")]
		private Unit _GetUnit(string id)
		{
			return null;
		}

		// Token: 0x060110BC RID: 69820 RVA: 0x00068F28 File Offset: 0x00067128
		[Token(Token = "0x60110BC")]
		[Address(RVA = "0x8EDCE0", Offset = "0x8EC8E0", VA = "0x1808EDCE0")]
		private bool _DoExecuteActionArray(Command command, string actionKey)
		{
			return default(bool);
		}

		// Token: 0x060110BD RID: 69821 RVA: 0x00068F40 File Offset: 0x00067140
		[Token(Token = "0x60110BD")]
		[Address(RVA = "0x8EB870", Offset = "0x8EA470", VA = "0x1808EB870")]
		private bool DoExecuteActionArrayByBlackboard(Command command, DialogueActionCommand actionCommand)
		{
			return default(bool);
		}

		// Token: 0x060110BE RID: 69822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110BE")]
		[Address(RVA = "0x8F2370", Offset = "0x8F0F70", VA = "0x1808F2370")]
		private void _MarkAsDialogTarget(Entity entity, bool isDialogTarget)
		{
		}

		// Token: 0x060110BF RID: 69823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110BF")]
		[Address(RVA = "0x8EC950", Offset = "0x8EB550", VA = "0x1808EC950")]
		public void Init()
		{
		}

		// Token: 0x060110C0 RID: 69824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C0")]
		[Address(RVA = "0x8EB660", Offset = "0x8EA260", VA = "0x1808EB660")]
		public void Clear()
		{
		}

		// Token: 0x060110C1 RID: 69825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C1")]
		[Address(RVA = "0x8ED2F0", Offset = "0x8EBEF0", VA = "0x1808ED2F0")]
		public void StartDialogWithDelay(string signal, float delay)
		{
		}

		// Token: 0x060110C2 RID: 69826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110C2")]
		[Address(RVA = "0x8F2560", Offset = "0x8F1160", VA = "0x1808F2560")]
		public IEnumerator _StartDialogDelayDialog(string signal, float delay)
		{
			return null;
		}

		// Token: 0x060110C3 RID: 69827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C3")]
		[Address(RVA = "0x8ED4A0", Offset = "0x8EC0A0", VA = "0x1808ED4A0")]
		public void StartDialog(string signal)
		{
		}

		// Token: 0x060110C4 RID: 69828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C4")]
		[Address(RVA = "0x8ED560", Offset = "0x8EC160", VA = "0x1808ED560")]
		public void StartDialog(string signal, Entity source)
		{
		}

		// Token: 0x060110C5 RID: 69829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C5")]
		[Address(RVA = "0x8ED6D0", Offset = "0x8EC2D0", VA = "0x1808ED6D0")]
		public void StopCurrentDialog()
		{
		}

		// Token: 0x060110C6 RID: 69830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C6")]
		[Address(RVA = "0x8ECF20", Offset = "0x8EBB20", VA = "0x1808ECF20")]
		public void OnTick(FP delatTime)
		{
		}

		// Token: 0x060110C7 RID: 69831 RVA: 0x00068F58 File Offset: 0x00067158
		[Token(Token = "0x60110C7")]
		[Address(RVA = "0x8ED990", Offset = "0x8EC590", VA = "0x1808ED990")]
		private bool TryStartPendingSourceSignal()
		{
			return default(bool);
		}

		// Token: 0x060110C8 RID: 69832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C8")]
		[Address(RVA = "0x8EB4C0", Offset = "0x8EA0C0", VA = "0x1808EB4C0")]
		public void AddSignalHook(string originSignal, string targetSignal)
		{
		}

		// Token: 0x060110C9 RID: 69833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110C9")]
		[Address(RVA = "0x8ED880", Offset = "0x8EC480", VA = "0x1808ED880")]
		private void TryStartPendingSignal()
		{
		}

		// Token: 0x060110CA RID: 69834 RVA: 0x00068F70 File Offset: 0x00067170
		[Token(Token = "0x60110CA")]
		[Address(RVA = "0x8ECE40", Offset = "0x8EBA40", VA = "0x1808ECE40")]
		public bool IsSignalValid(DialogController.SignalWithSource signalWithSource)
		{
			return default(bool);
		}

		// Token: 0x060110CB RID: 69835 RVA: 0x00068F88 File Offset: 0x00067188
		[Token(Token = "0x60110CB")]
		[Address(RVA = "0x8EDE30", Offset = "0x8ECA30", VA = "0x1808EDE30")]
		private bool _DoStartSignal(BattleDialogType type)
		{
			return default(bool);
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x060110CC RID: 69836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002593")]
		public Blackboard blackboard
		{
			[Token(Token = "0x60110CC")]
			[Address(RVA = "0x8F2B20", Offset = "0x8F1720", VA = "0x1808F2B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060110CD RID: 69837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110CD")]
		[Address(RVA = "0x8EC060", Offset = "0x8EAC60", VA = "0x1808EC060")]
		public Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x060110CE RID: 69838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110CE")]
		[Address(RVA = "0x8EBBA0", Offset = "0x8EA7A0", VA = "0x1808EBBA0")]
		public IEnumerator EndDialog()
		{
			return null;
		}

		// Token: 0x060110CF RID: 69839 RVA: 0x00068FA0 File Offset: 0x000671A0
		[Token(Token = "0x60110CF")]
		[Address(RVA = "0x8EF120", Offset = "0x8EDD20", VA = "0x1808EF120")]
		private bool _ExecuteEnd(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D0 RID: 69840 RVA: 0x00068FB8 File Offset: 0x000671B8
		[Token(Token = "0x60110D0")]
		[Address(RVA = "0x8EEA20", Offset = "0x8ED620", VA = "0x1808EEA20")]
		private bool _ExecuteCondition(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D1 RID: 69841 RVA: 0x00068FD0 File Offset: 0x000671D0
		[Token(Token = "0x60110D1")]
		[Address(RVA = "0x8F0620", Offset = "0x8EF220", VA = "0x1808F0620")]
		private bool _ExecutePredicate(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D2 RID: 69842 RVA: 0x00068FE8 File Offset: 0x000671E8
		[Token(Token = "0x60110D2")]
		[Address(RVA = "0x8F11C0", Offset = "0x8EFDC0", VA = "0x1808F11C0")]
		private bool _ExecuteTrue(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D3 RID: 69843 RVA: 0x00069000 File Offset: 0x00067200
		[Token(Token = "0x60110D3")]
		[Address(RVA = "0x8EF7A0", Offset = "0x8EE3A0", VA = "0x1808EF7A0")]
		private bool _ExecuteHeader(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D4 RID: 69844 RVA: 0x00069018 File Offset: 0x00067218
		[Token(Token = "0x60110D4")]
		[Address(RVA = "0x8EE200", Offset = "0x8ECE00", VA = "0x1808EE200")]
		private bool _ExecuteActionArray(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D5 RID: 69845 RVA: 0x00069030 File Offset: 0x00067230
		[Token(Token = "0x60110D5")]
		[Address(RVA = "0x8EEB40", Offset = "0x8ED740", VA = "0x1808EEB40")]
		private bool _ExecuteCreateEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D6 RID: 69846 RVA: 0x00069048 File Offset: 0x00067248
		[Token(Token = "0x60110D6")]
		[Address(RVA = "0x8EF500", Offset = "0x8EE100", VA = "0x1808EF500")]
		private bool _ExecuteFinishEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D7 RID: 69847 RVA: 0x00069060 File Offset: 0x00067260
		[Token(Token = "0x60110D7")]
		[Address(RVA = "0x8F1230", Offset = "0x8EFE30", VA = "0x1808F1230")]
		private bool _ExecuteWithdrawById(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D8 RID: 69848 RVA: 0x00069078 File Offset: 0x00067278
		[Token(Token = "0x60110D8")]
		[Address(RVA = "0x8F0780", Offset = "0x8EF380", VA = "0x1808F0780")]
		private bool _ExecuteSetPosition(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110D9 RID: 69849 RVA: 0x00069090 File Offset: 0x00067290
		[Token(Token = "0x60110D9")]
		[Address(RVA = "0x8EE370", Offset = "0x8ECF70", VA = "0x1808EE370")]
		private bool _ExecuteCameraFocusTo(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DA RID: 69850 RVA: 0x000690A8 File Offset: 0x000672A8
		[Token(Token = "0x60110DA")]
		[Address(RVA = "0x8EE6B0", Offset = "0x8ED2B0", VA = "0x1808EE6B0")]
		private bool _ExecuteCameraScale(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DB RID: 69851 RVA: 0x000690C0 File Offset: 0x000672C0
		[Token(Token = "0x60110DB")]
		[Address(RVA = "0x8F01A0", Offset = "0x8EEDA0", VA = "0x1808F01A0")]
		private bool _ExecutePlayAnim(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DC RID: 69852 RVA: 0x000690D8 File Offset: 0x000672D8
		[Token(Token = "0x60110DC")]
		[Address(RVA = "0x8F0690", Offset = "0x8EF290", VA = "0x1808F0690")]
		private bool _ExecuteResetCamera(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DD RID: 69853 RVA: 0x000690F0 File Offset: 0x000672F0
		[Token(Token = "0x60110DD")]
		[Address(RVA = "0x8F0DB0", Offset = "0x8EF9B0", VA = "0x1808F0DB0")]
		private bool _ExecuteSummonTrap(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DE RID: 69854 RVA: 0x00069108 File Offset: 0x00067308
		[Token(Token = "0x60110DE")]
		[Address(RVA = "0x8F0AE0", Offset = "0x8EF6E0", VA = "0x1808F0AE0")]
		private bool _ExecuteSummonEnemy(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110DF RID: 69855 RVA: 0x00069120 File Offset: 0x00067320
		[Token(Token = "0x60110DF")]
		[Address(RVA = "0x8EFD20", Offset = "0x8EE920", VA = "0x1808EFD20")]
		private bool _ExecuteMoveEnemy(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E0 RID: 69856 RVA: 0x00069138 File Offset: 0x00067338
		[Token(Token = "0x60110E0")]
		[Address(RVA = "0x8EEFB0", Offset = "0x8EDBB0", VA = "0x1808EEFB0")]
		private bool _ExecuteEmoji(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E1 RID: 69857 RVA: 0x00069150 File Offset: 0x00067350
		[Token(Token = "0x60110E1")]
		[Address(RVA = "0x8EE840", Offset = "0x8ED440", VA = "0x1808EE840")]
		private bool _ExecuteChangeSignal(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E2 RID: 69858 RVA: 0x00069168 File Offset: 0x00067368
		[Token(Token = "0x60110E2")]
		[Address(RVA = "0x8F10A0", Offset = "0x8EFCA0", VA = "0x1808F10A0")]
		private bool _ExecuteTimeScale(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E3 RID: 69859 RVA: 0x00069180 File Offset: 0x00067380
		[Token(Token = "0x60110E3")]
		[Address(RVA = "0x8F08F0", Offset = "0x8EF4F0", VA = "0x1808F08F0")]
		private bool _ExecuteShake(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E4 RID: 69860 RVA: 0x00069198 File Offset: 0x00067398
		[Token(Token = "0x60110E4")]
		[Address(RVA = "0x8EBD20", Offset = "0x8EA920", VA = "0x1808EBD20")]
		public bool ExecuteCommand(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110E5 RID: 69861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110E5")]
		[Address(RVA = "0x8EB6E0", Offset = "0x8EA2E0", VA = "0x1808EB6E0")]
		public List<BattleDialogOption> ConstructOptionsFromCommand(Command command)
		{
			return null;
		}

		// Token: 0x060110E6 RID: 69862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110E6")]
		[Address(RVA = "0x8EBE40", Offset = "0x8EAA40", VA = "0x1808EBE40")]
		public void FinishGame()
		{
		}

		// Token: 0x060110E7 RID: 69863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110E7")]
		[Address(RVA = "0x8EBFA0", Offset = "0x8EABA0", VA = "0x1808EBFA0")]
		public string GetBeforeBattleSignal()
		{
			return null;
		}

		// Token: 0x060110E8 RID: 69864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110E8")]
		[Address(RVA = "0x8EBEE0", Offset = "0x8EAAE0", VA = "0x1808EBEE0")]
		public string GetAfterBattleSignal()
		{
			return null;
		}

		// Token: 0x060110E9 RID: 69865 RVA: 0x000691B0 File Offset: 0x000673B0
		[Token(Token = "0x60110E9")]
		[Address(RVA = "0x8EB5E0", Offset = "0x8EA1E0", VA = "0x1808EB5E0")]
		public bool CheckContainsValidAfterBattleSignal()
		{
			return default(bool);
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x060110EA RID: 69866 RVA: 0x000691C8 File Offset: 0x000673C8
		[Token(Token = "0x17002594")]
		public bool hasWaveBeforeBattle
		{
			[Token(Token = "0x60110EA")]
			[Address(RVA = "0x8F2C20", Offset = "0x8F1820", VA = "0x1808F2C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x060110EB RID: 69867 RVA: 0x000691E0 File Offset: 0x000673E0
		[Token(Token = "0x17002595")]
		public bool hasWaveAfterBattle
		{
			[Token(Token = "0x60110EB")]
			[Address(RVA = "0x8F2B80", Offset = "0x8F1780", VA = "0x1808F2B80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060110EC RID: 69868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110EC")]
		[Address(RVA = "0x8EDC30", Offset = "0x8EC830", VA = "0x1808EDC30", Slot = "6")]
		public IEnumerator WaveBeforeBattle()
		{
			return null;
		}

		// Token: 0x060110ED RID: 69869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110ED")]
		[Address(RVA = "0x8EDB80", Offset = "0x8EC780", VA = "0x1808EDB80", Slot = "7")]
		public IEnumerator WaveAfterBattle()
		{
			return null;
		}

		// Token: 0x060110EE RID: 69870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110EE")]
		[Address(RVA = "0x8F2650", Offset = "0x8F1250", VA = "0x1808F2650")]
		public DialogController()
		{
		}

		// Token: 0x04013178 RID: 78200
		[Token(Token = "0x4013178")]
		[FieldOffset(Offset = "0x10")]
		private AVGParser m_parser;

		// Token: 0x04013179 RID: 78201
		[Token(Token = "0x4013179")]
		[FieldOffset(Offset = "0x18")]
		private DirectAssetLoader m_assetLoader;

		// Token: 0x0401317A RID: 78202
		[Token(Token = "0x401317A")]
		[FieldOffset(Offset = "0x20")]
		private PeriodicTimer m_intervalTicker;

		// Token: 0x0401317B RID: 78203
		[Token(Token = "0x401317B")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, ObjectPtr<Effect>> m_effects;

		// Token: 0x0401317C RID: 78204
		[Token(Token = "0x401317C")]
		[FieldOffset(Offset = "0x30")]
		public Action<BattleDialogParam> onSignalStart;

		// Token: 0x0401317D RID: 78205
		[Token(Token = "0x401317D")]
		[FieldOffset(Offset = "0x38")]
		public Action onSignalEnd;

		// Token: 0x0401317E RID: 78206
		[Token(Token = "0x401317E")]
		[FieldOffset(Offset = "0x40")]
		private string m_beforeBattleSignal;

		// Token: 0x0401317F RID: 78207
		[Token(Token = "0x401317F")]
		[FieldOffset(Offset = "0x48")]
		private string m_afterBattleSignal;

		// Token: 0x04013180 RID: 78208
		[Token(Token = "0x4013180")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasPlayedAfterBattleSignal;

		// Token: 0x04013181 RID: 78209
		[Token(Token = "0x4013181")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine m_delayCoroutine;

		// Token: 0x04013182 RID: 78210
		[Token(Token = "0x4013182")]
		[FieldOffset(Offset = "0x60")]
		private bool m_gameHasFinished;

		// Token: 0x04013183 RID: 78211
		[Token(Token = "0x4013183")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<GameModeMeta.GameModeType, DialogController.DialogControllerGameModePlugin> m_gameModePlugin;

		// Token: 0x04013184 RID: 78212
		[Token(Token = "0x4013184")]
		[FieldOffset(Offset = "0x70")]
		private BattleStoryTree m_storyTree;

		// Token: 0x04013185 RID: 78213
		[Token(Token = "0x4013185")]
		[FieldOffset(Offset = "0x78")]
		private List<string> m_pendingSignal;

		// Token: 0x04013186 RID: 78214
		[Token(Token = "0x4013186")]
		[FieldOffset(Offset = "0x80")]
		private List<DialogController.SignalWithSource> m_pendingSourceSignal;

		// Token: 0x04013187 RID: 78215
		[Token(Token = "0x4013187")]
		[FieldOffset(Offset = "0x88")]
		private ListDict<string, string> m_signalHook;

		// Token: 0x04013188 RID: 78216
		[Token(Token = "0x4013188")]
		[FieldOffset(Offset = "0x90")]
		private string m_currentSignal;

		// Token: 0x04013189 RID: 78217
		[Token(Token = "0x4013189")]
		[FieldOffset(Offset = "0x98")]
		private DialogController.DialogControllerGameModePlugin m_modePlugin;

		// Token: 0x0401318A RID: 78218
		[Token(Token = "0x401318A")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, DialogueActionCommand> m_actionCommands;

		// Token: 0x0401318B RID: 78219
		[Token(Token = "0x401318B")]
		[FieldOffset(Offset = "0xA8")]
		private Blackboard m_blackboard;

		// Token: 0x0401318C RID: 78220
		[Token(Token = "0x401318C")]
		[FieldOffset(Offset = "0xB0")]
		private List<Entity> m_dialogTargets;

		// Token: 0x0401318D RID: 78221
		[Token(Token = "0x401318D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0401318E RID: 78222
		[Token(Token = "0x401318E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x0401318F RID: 78223
		[Token(Token = "0x401318F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_storyTree;

		// Token: 0x04013190 RID: 78224
		[Token(Token = "0x4013190")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExecuteCommandByIndex;

		// Token: 0x04013191 RID: 78225
		[Token(Token = "0x4013191")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitCommandDicIfNot;

		// Token: 0x04013192 RID: 78226
		[Token(Token = "0x4013192")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCharNpc;

		// Token: 0x04013193 RID: 78227
		[Token(Token = "0x4013193")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetEnemyNpc;

		// Token: 0x04013194 RID: 78228
		[Token(Token = "0x4013194")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetEnemyNpcByAlias;

		// Token: 0x04013195 RID: 78229
		[Token(Token = "0x4013195")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetNpc;

		// Token: 0x04013196 RID: 78230
		[Token(Token = "0x4013196")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetUnit;

		// Token: 0x04013197 RID: 78231
		[Token(Token = "0x4013197")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoExecuteActionArray;

		// Token: 0x04013198 RID: 78232
		[Token(Token = "0x4013198")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoExecuteActionArrayByBlackboard;

		// Token: 0x04013199 RID: 78233
		[Token(Token = "0x4013199")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__MarkAsDialogTarget;

		// Token: 0x0401319A RID: 78234
		[Token(Token = "0x401319A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401319B RID: 78235
		[Token(Token = "0x401319B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0401319C RID: 78236
		[Token(Token = "0x401319C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_StartDialogWithDelay;

		// Token: 0x0401319D RID: 78237
		[Token(Token = "0x401319D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__StartDialogDelayDialog;

		// Token: 0x0401319E RID: 78238
		[Token(Token = "0x401319E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StartDialog;

		// Token: 0x0401319F RID: 78239
		[Token(Token = "0x401319F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1_StartDialog;

		// Token: 0x040131A0 RID: 78240
		[Token(Token = "0x40131A0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_StopCurrentDialog;

		// Token: 0x040131A1 RID: 78241
		[Token(Token = "0x40131A1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040131A2 RID: 78242
		[Token(Token = "0x40131A2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryStartPendingSourceSignal;

		// Token: 0x040131A3 RID: 78243
		[Token(Token = "0x40131A3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_AddSignalHook;

		// Token: 0x040131A4 RID: 78244
		[Token(Token = "0x40131A4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TryStartPendingSignal;

		// Token: 0x040131A5 RID: 78245
		[Token(Token = "0x40131A5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsSignalValid;

		// Token: 0x040131A6 RID: 78246
		[Token(Token = "0x40131A6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DoStartSignal;

		// Token: 0x040131A7 RID: 78247
		[Token(Token = "0x40131A7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x040131A8 RID: 78248
		[Token(Token = "0x40131A8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040131A9 RID: 78249
		[Token(Token = "0x40131A9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EndDialog;

		// Token: 0x040131AA RID: 78250
		[Token(Token = "0x40131AA")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ExecuteEnd;

		// Token: 0x040131AB RID: 78251
		[Token(Token = "0x40131AB")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ExecuteCondition;

		// Token: 0x040131AC RID: 78252
		[Token(Token = "0x40131AC")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ExecutePredicate;

		// Token: 0x040131AD RID: 78253
		[Token(Token = "0x40131AD")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ExecuteTrue;

		// Token: 0x040131AE RID: 78254
		[Token(Token = "0x40131AE")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ExecuteHeader;

		// Token: 0x040131AF RID: 78255
		[Token(Token = "0x40131AF")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ExecuteActionArray;

		// Token: 0x040131B0 RID: 78256
		[Token(Token = "0x40131B0")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ExecuteCreateEffect;

		// Token: 0x040131B1 RID: 78257
		[Token(Token = "0x40131B1")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ExecuteFinishEffect;

		// Token: 0x040131B2 RID: 78258
		[Token(Token = "0x40131B2")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ExecuteWithdrawById;

		// Token: 0x040131B3 RID: 78259
		[Token(Token = "0x40131B3")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ExecuteSetPosition;

		// Token: 0x040131B4 RID: 78260
		[Token(Token = "0x40131B4")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__ExecuteCameraFocusTo;

		// Token: 0x040131B5 RID: 78261
		[Token(Token = "0x40131B5")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__ExecuteCameraScale;

		// Token: 0x040131B6 RID: 78262
		[Token(Token = "0x40131B6")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__ExecutePlayAnim;

		// Token: 0x040131B7 RID: 78263
		[Token(Token = "0x40131B7")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ExecuteResetCamera;

		// Token: 0x040131B8 RID: 78264
		[Token(Token = "0x40131B8")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ExecuteSummonTrap;

		// Token: 0x040131B9 RID: 78265
		[Token(Token = "0x40131B9")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__ExecuteSummonEnemy;

		// Token: 0x040131BA RID: 78266
		[Token(Token = "0x40131BA")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ExecuteMoveEnemy;

		// Token: 0x040131BB RID: 78267
		[Token(Token = "0x40131BB")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__ExecuteEmoji;

		// Token: 0x040131BC RID: 78268
		[Token(Token = "0x40131BC")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__ExecuteChangeSignal;

		// Token: 0x040131BD RID: 78269
		[Token(Token = "0x40131BD")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ExecuteTimeScale;

		// Token: 0x040131BE RID: 78270
		[Token(Token = "0x40131BE")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__ExecuteShake;

		// Token: 0x040131BF RID: 78271
		[Token(Token = "0x40131BF")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_ExecuteCommand;

		// Token: 0x040131C0 RID: 78272
		[Token(Token = "0x40131C0")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_ConstructOptionsFromCommand;

		// Token: 0x040131C1 RID: 78273
		[Token(Token = "0x40131C1")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_FinishGame;

		// Token: 0x040131C2 RID: 78274
		[Token(Token = "0x40131C2")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_GetBeforeBattleSignal;

		// Token: 0x040131C3 RID: 78275
		[Token(Token = "0x40131C3")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_GetAfterBattleSignal;

		// Token: 0x040131C4 RID: 78276
		[Token(Token = "0x40131C4")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_CheckContainsValidAfterBattleSignal;

		// Token: 0x040131C5 RID: 78277
		[Token(Token = "0x40131C5")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_hasWaveBeforeBattle;

		// Token: 0x040131C6 RID: 78278
		[Token(Token = "0x40131C6")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_hasWaveAfterBattle;

		// Token: 0x040131C7 RID: 78279
		[Token(Token = "0x40131C7")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_WaveBeforeBattle;

		// Token: 0x040131C8 RID: 78280
		[Token(Token = "0x40131C8")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_WaveAfterBattle;

		// Token: 0x040131C9 RID: 78281
		[Token(Token = "0x40131C9")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200280C RID: 10252
		[Token(Token = "0x200280C")]
		public class DialogControllerGameModePlugin : IHotfixable
		{
			// Token: 0x17002596 RID: 9622
			// (get) Token: 0x060110F3 RID: 69875 RVA: 0x00069258 File Offset: 0x00067458
			[Token(Token = "0x17002596")]
			public virtual GameModeMeta.GameModeType mode
			{
				[Token(Token = "0x60110F3")]
				[Address(RVA = "0x8EB390", Offset = "0x8E9F90", VA = "0x1808EB390", Slot = "4")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002597 RID: 9623
			// (get) Token: 0x060110F4 RID: 69876 RVA: 0x00069270 File Offset: 0x00067470
			// (set) Token: 0x060110F5 RID: 69877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002597")]
			private protected BattleDialogParam param
			{
				[Token(Token = "0x60110F4")]
				[Address(RVA = "0x8EB3F0", Offset = "0x8E9FF0", VA = "0x1808EB3F0")]
				[CompilerGenerated]
				protected get
				{
					return default(BattleDialogParam);
				}
				[Token(Token = "0x60110F5")]
				[Address(RVA = "0x8EB450", Offset = "0x8EA050", VA = "0x1808EB450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002598 RID: 9624
			// (get) Token: 0x060110F6 RID: 69878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002598")]
			protected string currentSignal
			{
				[Token(Token = "0x60110F6")]
				[Address(RVA = "0x8EB300", Offset = "0x8E9F00", VA = "0x1808EB300")]
				get
				{
					return null;
				}
			}

			// Token: 0x060110F7 RID: 69879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60110F7")]
			[Address(RVA = "0x8EB040", Offset = "0x8E9C40", VA = "0x1808EB040", Slot = "5")]
			public virtual Dictionary<string, BattleStoryTree.Executor> GetExecutors()
			{
				return null;
			}

			// Token: 0x060110F8 RID: 69880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60110F8")]
			[Address(RVA = "0x8EB1C0", Offset = "0x8E9DC0", VA = "0x1808EB1C0", Slot = "6")]
			public virtual void OnSignalStart(string signal, BattleDialogParam param)
			{
			}

			// Token: 0x060110F9 RID: 69881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60110F9")]
			[Address(RVA = "0x8EB160", Offset = "0x8E9D60", VA = "0x1808EB160", Slot = "7")]
			public virtual void OnDialogEnd()
			{
			}

			// Token: 0x060110FA RID: 69882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60110FA")]
			[Address(RVA = "0x8EAFD0", Offset = "0x8E9BD0", VA = "0x1808EAFD0", Slot = "8")]
			public virtual string GetBeforeBattleSignal()
			{
				return null;
			}

			// Token: 0x060110FB RID: 69883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60110FB")]
			[Address(RVA = "0x8EAF60", Offset = "0x8E9B60", VA = "0x1808EAF60", Slot = "9")]
			public virtual string GetAfterBattleSignal()
			{
				return null;
			}

			// Token: 0x060110FC RID: 69884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60110FC")]
			[Address(RVA = "0x8EB100", Offset = "0x8E9D00", VA = "0x1808EB100", Slot = "10")]
			public virtual void OnBeforeBattleWaveEnd()
			{
			}

			// Token: 0x060110FD RID: 69885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60110FD")]
			[Address(RVA = "0x8EB0A0", Offset = "0x8E9CA0", VA = "0x1808EB0A0", Slot = "11")]
			public virtual void OnAfterBattleWaveStart()
			{
			}

			// Token: 0x060110FE RID: 69886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60110FE")]
			[Address(RVA = "0x8EB2A0", Offset = "0x8E9EA0", VA = "0x1808EB2A0")]
			public DialogControllerGameModePlugin()
			{
			}

			// Token: 0x040131CB RID: 78283
			[Token(Token = "0x40131CB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_mode;

			// Token: 0x040131CC RID: 78284
			[Token(Token = "0x40131CC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_param;

			// Token: 0x040131CD RID: 78285
			[Token(Token = "0x40131CD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_param;

			// Token: 0x040131CE RID: 78286
			[Token(Token = "0x40131CE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_currentSignal;

			// Token: 0x040131CF RID: 78287
			[Token(Token = "0x40131CF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetExecutors;

			// Token: 0x040131D0 RID: 78288
			[Token(Token = "0x40131D0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnSignalStart;

			// Token: 0x040131D1 RID: 78289
			[Token(Token = "0x40131D1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnDialogEnd;

			// Token: 0x040131D2 RID: 78290
			[Token(Token = "0x40131D2")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetBeforeBattleSignal;

			// Token: 0x040131D3 RID: 78291
			[Token(Token = "0x40131D3")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetAfterBattleSignal;

			// Token: 0x040131D4 RID: 78292
			[Token(Token = "0x40131D4")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnBeforeBattleWaveEnd;

			// Token: 0x040131D5 RID: 78293
			[Token(Token = "0x40131D5")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnAfterBattleWaveStart;

			// Token: 0x040131D6 RID: 78294
			[Token(Token = "0x40131D6")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200280D RID: 10253
		[Token(Token = "0x200280D")]
		public struct SignalWithSource
		{
			// Token: 0x040131D7 RID: 78295
			[Token(Token = "0x40131D7")]
			[FieldOffset(Offset = "0x0")]
			public Entity source;

			// Token: 0x040131D8 RID: 78296
			[Token(Token = "0x40131D8")]
			[FieldOffset(Offset = "0x8")]
			public string signal;
		}
	}
}

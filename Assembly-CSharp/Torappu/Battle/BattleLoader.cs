using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002196 RID: 8598
	[Token(Token = "0x2002196")]
	public class BattleLoader : AbstractBattleLoader
	{
		// Token: 0x0600D4E2 RID: 54498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E2")]
		[Address(RVA = "0x3587BD0", Offset = "0x35867D0", VA = "0x183587BD0")]
		private void Start()
		{
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E3")]
		[Address(RVA = "0x3587CD0", Offset = "0x35868D0", VA = "0x183587CD0")]
		private void _BeforeDoLoad()
		{
		}

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4E4")]
		[Address(RVA = "0x3588080", Offset = "0x3586C80", VA = "0x183588080")]
		private IEnumerator _DoLoad()
		{
			return null;
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E5")]
		[Address(RVA = "0x3588570", Offset = "0x3587170", VA = "0x183588570")]
		private static void _DoMultipleBattlePrepare(ref BattleInOut.InParams input)
		{
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E6")]
		[Address(RVA = "0x3588640", Offset = "0x3587240", VA = "0x183588640")]
		private void _DoRestartGamePrepare()
		{
		}

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E7")]
		[Address(RVA = "0x3588130", Offset = "0x3586D30", VA = "0x183588130")]
		private void _DoMultiplayerLoad(ref BattleInOut.InParams input)
		{
		}

		// Token: 0x0600D4E8 RID: 54504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4E8")]
		[Address(RVA = "0x35886F0", Offset = "0x35872F0", VA = "0x1835886F0")]
		private LevelData _GenerateSailBoatLevelData(string levelId)
		{
			return null;
		}

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4E9")]
		[Address(RVA = "0x3587DE0", Offset = "0x35869E0", VA = "0x183587DE0")]
		private ActMultiV3SailBoatBlockInfoData _CalculateBlockLevelData(ActMultiV3BlockDirType curExitDir, string blockPool, ActMultiV3Data actMultiV3Data, System.Random randomTemp)
		{
			return null;
		}

		// Token: 0x0600D4EA RID: 54506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4EA")]
		[Address(RVA = "0x3589800", Offset = "0x3588400", VA = "0x183589800")]
		private void _OnFailed(string error)
		{
		}

		// Token: 0x0600D4EB RID: 54507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4EB")]
		[Address(RVA = "0x3589270", Offset = "0x3587E70", VA = "0x183589270")]
		private void _LoadDummyLevel()
		{
		}

		// Token: 0x0600D4EC RID: 54508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4EC")]
		[Address(RVA = "0x3589980", Offset = "0x3588580", VA = "0x183589980")]
		public BattleLoader()
		{
		}

		// Token: 0x0400E48C RID: 58508
		[Token(Token = "0x400E48C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _minLoadingTime;

		// Token: 0x0400E48D RID: 58509
		[Token(Token = "0x400E48D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ResourceCollector _collector;

		// Token: 0x0400E48E RID: 58510
		[Token(Token = "0x400E48E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBattleLoading _loadingUI;

		// Token: 0x0400E48F RID: 58511
		[Token(Token = "0x400E48F")]
		[FieldOffset(Offset = "0x30")]
		private float m_startLoadingTime;

		// Token: 0x0400E490 RID: 58512
		[Token(Token = "0x400E490")]
		[FieldOffset(Offset = "0x38")]
		private List<PoolManager.ObjectConfig> m_configs;

		// Token: 0x0400E491 RID: 58513
		[Token(Token = "0x400E491")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400E492 RID: 58514
		[Token(Token = "0x400E492")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BeforeDoLoad;

		// Token: 0x0400E493 RID: 58515
		[Token(Token = "0x400E493")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoLoad;

		// Token: 0x0400E494 RID: 58516
		[Token(Token = "0x400E494")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoMultipleBattlePrepare;

		// Token: 0x0400E495 RID: 58517
		[Token(Token = "0x400E495")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoRestartGamePrepare;

		// Token: 0x0400E496 RID: 58518
		[Token(Token = "0x400E496")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoMultiplayerLoad;

		// Token: 0x0400E497 RID: 58519
		[Token(Token = "0x400E497")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateSailBoatLevelData;

		// Token: 0x0400E498 RID: 58520
		[Token(Token = "0x400E498")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculateBlockLevelData;

		// Token: 0x0400E499 RID: 58521
		[Token(Token = "0x400E499")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnFailed;

		// Token: 0x0400E49A RID: 58522
		[Token(Token = "0x400E49A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadDummyLevel;

		// Token: 0x0400E49B RID: 58523
		[Token(Token = "0x400E49B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002197 RID: 8599
		[Token(Token = "0x2002197")]
		private class LoadAdditiveModuleInstruction : CustomYieldInstruction
		{
			// Token: 0x170019C9 RID: 6601
			// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
			[Token(Token = "0x170019C9")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600D4ED")]
				[Address(RVA = "0x3599580", Offset = "0x3598180", VA = "0x183599580", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600D4EE RID: 54510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D4EE")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private LoadAdditiveModuleInstruction()
			{
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D4EF")]
			[Address(RVA = "0x3598FB0", Offset = "0x3597BB0", VA = "0x183598FB0")]
			public static BattleLoader.LoadAdditiveModuleInstruction Create(BattleLoader loader, BattleInOut battleInOut)
			{
				return null;
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D4F0")]
			[Address(RVA = "0x3599140", Offset = "0x3597D40", VA = "0x183599140")]
			private static List<CustomYieldInstruction> _CreateAdditiveLoadTasks(BattleLoader loader, BattleInOut battleInOut)
			{
				return null;
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D4F1")]
			[Address(RVA = "0x3599260", Offset = "0x3597E60", VA = "0x183599260")]
			private static CustomYieldInstruction _CreateLoadUISystem(BattleLoader loader, BattleInOut battleInOut)
			{
				return null;
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D4F2")]
			[Address(RVA = "0x3599520", Offset = "0x3598120", VA = "0x183599520")]
			private static IEnumerator _LoadUISystemCoroutine()
			{
				return null;
			}

			// Token: 0x0400E49C RID: 58524
			[Token(Token = "0x400E49C")]
			[FieldOffset(Offset = "0x10")]
			private List<CustomYieldInstruction> m_loadTasks;
		}
	}
}

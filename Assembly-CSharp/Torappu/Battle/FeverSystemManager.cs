using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002307 RID: 8967
	[Token(Token = "0x2002307")]
	public class FeverSystemManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E281 RID: 57985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E281")]
		[Address(RVA = "0x55E700", Offset = "0x55D300", VA = "0x18055E700", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E282 RID: 57986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E282")]
		[Address(RVA = "0x55EBC0", Offset = "0x55D7C0", VA = "0x18055EBC0")]
		private void _DropFever()
		{
		}

		// Token: 0x0600E283 RID: 57987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E283")]
		[Address(RVA = "0x55EC80", Offset = "0x55D880", VA = "0x18055EC80")]
		private void _UpdateFeverStep()
		{
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x0600E284 RID: 57988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C70")]
		public GameDataConsts.FeverGameData gameData
		{
			[Token(Token = "0x600E284")]
			[Address(RVA = "0x55F0F0", Offset = "0x55DCF0", VA = "0x18055F0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x0600E285 RID: 57989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C71")]
		public FeverSystemManager.FeverStatus data
		{
			[Token(Token = "0x600E285")]
			[Address(RVA = "0x55F090", Offset = "0x55DC90", VA = "0x18055F090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x0600E286 RID: 57990 RVA: 0x00052308 File Offset: 0x00050508
		[Token(Token = "0x17001C72")]
		public bool isFeverFull
		{
			[Token(Token = "0x600E286")]
			[Address(RVA = "0x55F1D0", Offset = "0x55DDD0", VA = "0x18055F1D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E287 RID: 57991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E287")]
		[Address(RVA = "0x55E360", Offset = "0x55CF60", VA = "0x18055E360")]
		public void MarkJoinFever(ObjectPtr<Entity> entity)
		{
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E288")]
		[Address(RVA = "0x55E520", Offset = "0x55D120", VA = "0x18055E520")]
		public void MarkLeaveFever(ObjectPtr<Entity> entity)
		{
		}

		// Token: 0x0600E289 RID: 57993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E289")]
		[Address(RVA = "0x55E920", Offset = "0x55D520", VA = "0x18055E920")]
		public void TryActiveFever(Entity entity)
		{
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E28A")]
		[Address(RVA = "0x55E200", Offset = "0x55CE00", VA = "0x18055E200")]
		public void AddFeverIfNotFull(Entity entityNullable, FP ferverValAdd)
		{
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E28B")]
		[Address(RVA = "0x55EF50", Offset = "0x55DB50", VA = "0x18055EF50")]
		public FeverSystemManager()
		{
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E28C")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F84C RID: 63564
		[Token(Token = "0x400F84C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _feverStartEvent;

		// Token: 0x0400F84D RID: 63565
		[Token(Token = "0x400F84D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _feverCharacterJoinEvent;

		// Token: 0x0400F84E RID: 63566
		[Token(Token = "0x400F84E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _feverCharacterLeaveEvent;

		// Token: 0x0400F84F RID: 63567
		[Token(Token = "0x400F84F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<FeverSystemManager.FeverStepSetting> _feverSteps;

		// Token: 0x0400F850 RID: 63568
		[Token(Token = "0x400F850")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, int> m_feverCharacterSet;

		// Token: 0x0400F851 RID: 63569
		[Token(Token = "0x400F851")]
		[FieldOffset(Offset = "0x50")]
		private FeverSystemManager.FeverStatus m_data;

		// Token: 0x0400F852 RID: 63570
		[Token(Token = "0x400F852")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F853 RID: 63571
		[Token(Token = "0x400F853")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DropFever;

		// Token: 0x0400F854 RID: 63572
		[Token(Token = "0x400F854")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateFeverStep;

		// Token: 0x0400F855 RID: 63573
		[Token(Token = "0x400F855")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_gameData;

		// Token: 0x0400F856 RID: 63574
		[Token(Token = "0x400F856")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0400F857 RID: 63575
		[Token(Token = "0x400F857")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isFeverFull;

		// Token: 0x0400F858 RID: 63576
		[Token(Token = "0x400F858")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MarkJoinFever;

		// Token: 0x0400F859 RID: 63577
		[Token(Token = "0x400F859")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_MarkLeaveFever;

		// Token: 0x0400F85A RID: 63578
		[Token(Token = "0x400F85A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryActiveFever;

		// Token: 0x0400F85B RID: 63579
		[Token(Token = "0x400F85B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AddFeverIfNotFull;

		// Token: 0x0400F85C RID: 63580
		[Token(Token = "0x400F85C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002308 RID: 8968
		[Token(Token = "0x2002308")]
		public class FeverStatus
		{
			// Token: 0x0600E28D RID: 57997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E28D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeverStatus()
			{
			}

			// Token: 0x0400F85D RID: 63581
			[Token(Token = "0x400F85D")]
			[FieldOffset(Offset = "0x10")]
			public bool inFever;

			// Token: 0x0400F85E RID: 63582
			[Token(Token = "0x400F85E")]
			[FieldOffset(Offset = "0x18")]
			public FP feverRemainingTime;

			// Token: 0x0400F85F RID: 63583
			[Token(Token = "0x400F85F")]
			[FieldOffset(Offset = "0x20")]
			public FP feverCollected;

			// Token: 0x0400F860 RID: 63584
			[Token(Token = "0x400F860")]
			[FieldOffset(Offset = "0x28")]
			public int feverCharacterCount;

			// Token: 0x0400F861 RID: 63585
			[Token(Token = "0x400F861")]
			[FieldOffset(Offset = "0x2C")]
			public uint feverSourceInstanceId;
		}

		// Token: 0x02002309 RID: 8969
		[Token(Token = "0x2002309")]
		[Serializable]
		public class FeverStepSetting
		{
			// Token: 0x0600E28E RID: 57998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E28E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeverStepSetting()
			{
			}

			// Token: 0x0400F862 RID: 63586
			[Token(Token = "0x400F862")]
			[FieldOffset(Offset = "0x10")]
			public int feverCharacterCount;

			// Token: 0x0400F863 RID: 63587
			[Token(Token = "0x400F863")]
			[FieldOffset(Offset = "0x18")]
			public string feverStepEvent;
		}
	}
}

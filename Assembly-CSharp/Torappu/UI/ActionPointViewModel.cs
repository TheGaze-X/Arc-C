using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003894 RID: 14484
	[Token(Token = "0x2003894")]
	public class ActionPointViewModel : PageSingleComponent, ITimeWatcher, IPlayerDataListener, IHotfixable, IDataBindWrapper
	{
		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x06016EDE RID: 93918 RVA: 0x00093EE8 File Offset: 0x000920E8
		[Token(Token = "0x170036C4")]
		protected int apRegenMinutes
		{
			[Token(Token = "0x6016EDE")]
			[Address(RVA = "0xF53CA0", Offset = "0xF528A0", VA = "0x180F53CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x06016EDF RID: 93919 RVA: 0x00093F00 File Offset: 0x00092100
		[Token(Token = "0x170036C5")]
		public int apRegenSeconds
		{
			[Token(Token = "0x6016EDF")]
			[Address(RVA = "0xF53D30", Offset = "0xF52930", VA = "0x180F53D30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x06016EE0 RID: 93920 RVA: 0x00093F18 File Offset: 0x00092118
		[Token(Token = "0x170036C6")]
		public DateTime lastApAddTime
		{
			[Token(Token = "0x6016EE0")]
			[Address(RVA = "0xF53E10", Offset = "0xF52A10", VA = "0x180F53E10")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x06016EE1 RID: 93921 RVA: 0x00093F30 File Offset: 0x00092130
		[Token(Token = "0x170036C7")]
		public bool isApFull
		{
			[Token(Token = "0x6016EE1")]
			[Address(RVA = "0xF53D90", Offset = "0xF52990", VA = "0x180F53D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x00093F48 File Offset: 0x00092148
		[Token(Token = "0x6016EE2")]
		[Address(RVA = "0xF53360", Offset = "0xF51F60", VA = "0x180F53360", Slot = "13")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE3")]
		[Address(RVA = "0xF534F0", Offset = "0xF520F0", VA = "0x180F534F0", Slot = "14")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE4")]
		[Address(RVA = "0xF537F0", Offset = "0xF523F0", VA = "0x180F537F0", Slot = "12")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE5")]
		[Address(RVA = "0xF53470", Offset = "0xF52070", VA = "0x180F53470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06016EE6 RID: 93926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE6")]
		[Address(RVA = "0xF53690", Offset = "0xF52290", VA = "0x180F53690", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x06016EE7 RID: 93927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE7")]
		[Address(RVA = "0xF53700", Offset = "0xF52300", VA = "0x180F53700", Slot = "9")]
		protected override void OnStop()
		{
		}

		// Token: 0x06016EE8 RID: 93928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE8")]
		[Address(RVA = "0xF53880", Offset = "0xF52480", VA = "0x180F53880")]
		private void _UpdateCurrentAp()
		{
		}

		// Token: 0x06016EE9 RID: 93929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EE9")]
		[Address(RVA = "0xF53790", Offset = "0xF52390", VA = "0x180F53790", Slot = "15")]
		protected virtual void UpdateApInfo()
		{
		}

		// Token: 0x06016EEA RID: 93930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EEA")]
		[Address(RVA = "0xF53B40", Offset = "0xF52740", VA = "0x180F53B40")]
		public ActionPointViewModel()
		{
		}

		// Token: 0x06016EEB RID: 93931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EEB")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EEC")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06016EED RID: 93933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EED")]
		[Address(RVA = "0xF53780", Offset = "0xF52380", VA = "0x180F53780")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0401BAA6 RID: 113318
		[Token(Token = "0x401BAA6")]
		private const float UPDATE_INTERVAL = 1f;

		// Token: 0x0401BAA7 RID: 113319
		[Token(Token = "0x401BAA7")]
		[FieldOffset(Offset = "0x20")]
		public IntProperty apProperty;

		// Token: 0x0401BAA8 RID: 113320
		[Token(Token = "0x401BAA8")]
		[FieldOffset(Offset = "0x28")]
		public IntProperty maxApProperty;

		// Token: 0x0401BAA9 RID: 113321
		[Token(Token = "0x401BAA9")]
		[FieldOffset(Offset = "0x30")]
		public APInfoProperty apInfoProperty;

		// Token: 0x0401BAAA RID: 113322
		[Token(Token = "0x401BAAA")]
		[FieldOffset(Offset = "0x38")]
		private float m_timeAccum;

		// Token: 0x0401BAAB RID: 113323
		[Token(Token = "0x401BAAB")]
		[FieldOffset(Offset = "0x40")]
		private DateTime m_lastApAddTime;

		// Token: 0x0401BAAC RID: 113324
		[Token(Token = "0x401BAAC")]
		[FieldOffset(Offset = "0x48")]
		private int m_apRegenMinutes;

		// Token: 0x0401BAAD RID: 113325
		[Token(Token = "0x401BAAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_apRegenMinutes;

		// Token: 0x0401BAAE RID: 113326
		[Token(Token = "0x401BAAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_apRegenSeconds;

		// Token: 0x0401BAAF RID: 113327
		[Token(Token = "0x401BAAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lastApAddTime;

		// Token: 0x0401BAB0 RID: 113328
		[Token(Token = "0x401BAB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isApFull;

		// Token: 0x0401BAB1 RID: 113329
		[Token(Token = "0x401BAB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0401BAB2 RID: 113330
		[Token(Token = "0x401BAB2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0401BAB3 RID: 113331
		[Token(Token = "0x401BAB3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401BAB4 RID: 113332
		[Token(Token = "0x401BAB4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401BAB5 RID: 113333
		[Token(Token = "0x401BAB5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401BAB6 RID: 113334
		[Token(Token = "0x401BAB6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401BAB7 RID: 113335
		[Token(Token = "0x401BAB7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateCurrentAp;

		// Token: 0x0401BAB8 RID: 113336
		[Token(Token = "0x401BAB8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateApInfo;

		// Token: 0x0401BAB9 RID: 113337
		[Token(Token = "0x401BAB9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

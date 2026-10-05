using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017FB RID: 6139
	[Token(Token = "0x20017FB")]
	public class BuildingLaborViewModel : IHotfixable
	{
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x0003C4F8 File Offset: 0x0003A6F8
		// (set) Token: 0x06009B07 RID: 39687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010EB")]
		public int maxLabor
		{
			[Token(Token = "0x6009B06")]
			[Address(RVA = "0x3154540", Offset = "0x3153140", VA = "0x183154540")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009B07")]
			[Address(RVA = "0x31549A0", Offset = "0x31535A0", VA = "0x1831549A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x0003C510 File Offset: 0x0003A710
		// (set) Token: 0x06009B09 RID: 39689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010EC")]
		public float buffSpeed
		{
			[Token(Token = "0x6009B08")]
			[Address(RVA = "0x3154380", Offset = "0x3152F80", VA = "0x183154380")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6009B09")]
			[Address(RVA = "0x31548C0", Offset = "0x31534C0", VA = "0x1831548C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06009B0A RID: 39690 RVA: 0x0003C528 File Offset: 0x0003A728
		[Token(Token = "0x170010ED")]
		public bool isLaborFull
		{
			[Token(Token = "0x6009B0A")]
			[Address(RVA = "0x3154440", Offset = "0x3153040", VA = "0x183154440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06009B0B RID: 39691 RVA: 0x0003C540 File Offset: 0x0003A740
		[Token(Token = "0x170010EE")]
		public long remainSeconds
		{
			[Token(Token = "0x6009B0B")]
			[Address(RVA = "0x3154670", Offset = "0x3153270", VA = "0x183154670")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x0003C558 File Offset: 0x0003A758
		[Token(Token = "0x170010EF")]
		public float totalRemainSeconds
		{
			[Token(Token = "0x6009B0C")]
			[Address(RVA = "0x31546E0", Offset = "0x31532E0", VA = "0x1831546E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06009B0D RID: 39693 RVA: 0x0003C570 File Offset: 0x0003A770
		[Token(Token = "0x170010F0")]
		public float progress
		{
			[Token(Token = "0x6009B0D")]
			[Address(RVA = "0x31545A0", Offset = "0x31531A0", VA = "0x1831545A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06009B0E RID: 39694 RVA: 0x0003C588 File Offset: 0x0003A788
		// (set) Token: 0x06009B0F RID: 39695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F1")]
		public int currentLabor
		{
			[Token(Token = "0x6009B0E")]
			[Address(RVA = "0x31543E0", Offset = "0x3152FE0", VA = "0x1831543E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009B0F")]
			[Address(RVA = "0x3154930", Offset = "0x3153530", VA = "0x183154930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B10")]
		[Address(RVA = "0x3153E30", Offset = "0x3152A30", VA = "0x183153E30")]
		public void Tick()
		{
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B11")]
		[Address(RVA = "0x3154200", Offset = "0x3152E00", VA = "0x183154200")]
		public BuildingLaborViewModel()
		{
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B12")]
		[Address(RVA = "0x3153AF0", Offset = "0x31526F0", VA = "0x183153AF0")]
		public void LoadData()
		{
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B13")]
		[Address(RVA = "0x3153F00", Offset = "0x3152B00", VA = "0x183153F00")]
		private void _UpdateStatus()
		{
		}

		// Token: 0x04009165 RID: 37221
		[Token(Token = "0x4009165")]
		[FieldOffset(Offset = "0x10")]
		private long m_laborRecoverPoint;

		// Token: 0x04009166 RID: 37222
		[Token(Token = "0x4009166")]
		[FieldOffset(Offset = "0x18")]
		private DateTime m_lastServiceTime;

		// Token: 0x04009167 RID: 37223
		[Token(Token = "0x4009167")]
		[FieldOffset(Offset = "0x20")]
		private int m_lastServiceLabor;

		// Token: 0x04009168 RID: 37224
		[Token(Token = "0x4009168")]
		[FieldOffset(Offset = "0x28")]
		private double m_lastProcessPoint;

		// Token: 0x04009169 RID: 37225
		[Token(Token = "0x4009169")]
		[FieldOffset(Offset = "0x30")]
		private CountDownTask m_countDown;

		// Token: 0x0400916D RID: 37229
		[Token(Token = "0x400916D")]
		[FieldOffset(Offset = "0x48")]
		public Action<BuildingLaborViewModel> onValueTick;

		// Token: 0x0400916E RID: 37230
		[Token(Token = "0x400916E")]
		[FieldOffset(Offset = "0x50")]
		public Action<BuildingLaborViewModel> onValueChanged;

		// Token: 0x0400916F RID: 37231
		[Token(Token = "0x400916F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxLabor;

		// Token: 0x04009170 RID: 37232
		[Token(Token = "0x4009170")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_maxLabor;

		// Token: 0x04009171 RID: 37233
		[Token(Token = "0x4009171")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffSpeed;

		// Token: 0x04009172 RID: 37234
		[Token(Token = "0x4009172")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_buffSpeed;

		// Token: 0x04009173 RID: 37235
		[Token(Token = "0x4009173")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isLaborFull;

		// Token: 0x04009174 RID: 37236
		[Token(Token = "0x4009174")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_remainSeconds;

		// Token: 0x04009175 RID: 37237
		[Token(Token = "0x4009175")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_totalRemainSeconds;

		// Token: 0x04009176 RID: 37238
		[Token(Token = "0x4009176")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x04009177 RID: 37239
		[Token(Token = "0x4009177")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentLabor;

		// Token: 0x04009178 RID: 37240
		[Token(Token = "0x4009178")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_currentLabor;

		// Token: 0x04009179 RID: 37241
		[Token(Token = "0x4009179")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400917A RID: 37242
		[Token(Token = "0x400917A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400917B RID: 37243
		[Token(Token = "0x400917B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400917C RID: 37244
		[Token(Token = "0x400917C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateStatus;
	}
}

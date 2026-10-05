using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;
using UnityEngine;
using XLua;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class ReedTile : DynamicBuffTileFixed, IUpdateable
{
	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x50C1D0", Offset = "0x50ADD0", VA = "0x18050C1D0", Slot = "21")]
	public override void Init(TileData tileData, GridPosition pos)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x50C6D0", Offset = "0x50B2D0", VA = "0x18050C6D0", Slot = "26")]
	protected override void OnCharacterEnter(Character newChar, Character oldChar)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x50C7F0", Offset = "0x50B3F0", VA = "0x18050C7F0", Slot = "27")]
	protected override void OnCharacterLeave(Character character)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x50CA30", Offset = "0x50B630", VA = "0x18050CA30", Slot = "50")]
	protected override void OnSwitchMode(int mode)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x50C8A0", Offset = "0x50B4A0", VA = "0x18050C8A0", Slot = "52")]
	public void OnFixedUpdate(FP fixedDeltaTime)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x50D990", Offset = "0x50C590", VA = "0x18050D990")]
	private void _igniteSurroundReedTiles()
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x50D7F0", Offset = "0x50C3F0", VA = "0x18050D7F0")]
	private bool _ValidateTile(ReedTile tile)
	{
		return default(bool);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x50D370", Offset = "0x50BF70", VA = "0x18050D370")]
	private void _SwitchToIgniteMode(ReedTile reedTile)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x50CFA0", Offset = "0x50BBA0", VA = "0x18050CFA0")]
	private void _ResetAllTicker()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x50D750", Offset = "0x50C350", VA = "0x18050D750")]
	private void _UpdateTickersInIgniteMode(bool hasCharacter)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x50CC70", Offset = "0x50B870", VA = "0x18050CC70")]
	public void SwitchToOriginalIgniteMode()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x50CE10", Offset = "0x50BA10", VA = "0x18050CE10")]
	private void _FindSurroundReedTiles()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x50D4B0", Offset = "0x50C0B0", VA = "0x18050D4B0", Slot = "51")]
	protected override void _UpdateEffects()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x50D550", Offset = "0x50C150", VA = "0x18050D550")]
	private void _UpdateIgniteEffect()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x50D100", Offset = "0x50BD00", VA = "0x18050D100")]
	private void _SwitchIgniteEffect(int index)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x50D8D0", Offset = "0x50C4D0", VA = "0x18050D8D0")]
	public ReedTile()
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x50CDC0", Offset = "0x50B9C0", VA = "0x18050CDC0")]
	private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x50CDD0", Offset = "0x50B9D0", VA = "0x18050CDD0")]
	private void <>xLuaBaseProxy_OnCharacterEnter(Character P0, Character P1)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x50CDE0", Offset = "0x50B9E0", VA = "0x18050CDE0")]
	private void <>xLuaBaseProxy_OnCharacterLeave(Character P0)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
	private void <>xLuaBaseProxy_OnSwitchMode(int P0)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x50CE00", Offset = "0x50BA00", VA = "0x18050CE00")]
	private void <>xLuaBaseProxy__UpdateEffects()
	{
	}

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private string _igniteDurationKey;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private string _extinctDurationKey;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private string _coolDownDurationKey;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	private Range _reedRange;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	private string[] _igniteEffectGroup;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	private const int EXTINCT_MODE_INDEX = 0;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	private const int IGNITE_MODE_INDEX = 1;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	private const int COOLDOWN_MODE_INDEX = 2;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	private const int HIGHEST_INTENSITY_EFFECT_INDEX = 2;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	private const float IGNITE_EFFECT_CHECK_POINT = 0.3333f;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x210")]
	private int m_currIgniteEffectIndex;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x218")]
	private ReedTile.ReedTileTicker m_igniteTicker;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x220")]
	private ReedTile.ReedTileTicker m_extinctTicker;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x228")]
	private ReedTile.ReedTileTicker m_coolDownTicker;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x230")]
	private bool m_canIgniteOtherTiles;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x238")]
	private List<ReedTile> m_surroundTiles;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x0")]
	private static DelegateBridge __Hotfix0_Init;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x8")]
	private static DelegateBridge __Hotfix0_OnCharacterEnter;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x10")]
	private static DelegateBridge __Hotfix0_OnCharacterLeave;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x18")]
	private static DelegateBridge __Hotfix0_OnSwitchMode;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x20")]
	private static DelegateBridge __Hotfix0_OnFixedUpdate;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x28")]
	private static DelegateBridge __Hotfix0__igniteSurroundReedTiles;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x30")]
	private static DelegateBridge __Hotfix0__ValidateTile;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x38")]
	private static DelegateBridge __Hotfix0__SwitchToIgniteMode;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x40")]
	private static DelegateBridge __Hotfix0__ResetAllTicker;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x48")]
	private static DelegateBridge __Hotfix0__UpdateTickersInIgniteMode;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x50")]
	private static DelegateBridge __Hotfix0_SwitchToOriginalIgniteMode;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x58")]
	private static DelegateBridge __Hotfix0__FindSurroundReedTiles;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x60")]
	private static DelegateBridge __Hotfix0__UpdateEffects;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x68")]
	private static DelegateBridge __Hotfix0__UpdateIgniteEffect;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x70")]
	private static DelegateBridge __Hotfix0__SwitchIgniteEffect;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x78")]
	private static DelegateBridge _c__Hotfix0_ctor;

	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	private class ReedTileTicker
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000010")]
		public bool isReady
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x50C040", Offset = "0x50AC40", VA = "0x18050C040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000011")]
		public FP remainProcess
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x50C0D0", Offset = "0x50ACD0", VA = "0x18050C0D0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x50BF80", Offset = "0x50AB80", VA = "0x18050BF80")]
		public ReedTileTicker(Blackboard blackboard, string durationKey, bool isValid = true)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x50BEA0", Offset = "0x50AAA0", VA = "0x18050BEA0")]
		public void OnTick(FP deltaTIme)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x50BF20", Offset = "0x50AB20", VA = "0x18050BF20")]
		public void Reset()
		{
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		private FP m_maxDuration;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		private FP m_curDuration;
	}
}

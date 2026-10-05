using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;
using Torappu.Battle.LevelScript;
using Torappu.ObjectPool;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class LevelScriptRuntime : IReusableObject, IReusable, IPtrObject
{
	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00002268 File Offset: 0x00000468
	// (set) Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000017")]
	public uint instanceUid
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x508FA0", Offset = "0x507BA0", VA = "0x180508FA0")]
	public static LevelScriptRuntime NewLevelScriptRuntime()
	{
		return null;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x509190", Offset = "0x507D90", VA = "0x180509190", Slot = "4")]
	public void OnAllocate()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x5091E0", Offset = "0x507DE0", VA = "0x1805091E0", Slot = "5")]
	public void OnRecycle()
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x509580", Offset = "0x508180", VA = "0x180509580")]
	public void SetUp(LevelScriptData data)
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x509540", Offset = "0x508140", VA = "0x180509540")]
	public void ResetActionGraphParamBlackboard()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x508E80", Offset = "0x507A80", VA = "0x180508E80")]
	public void Append(LevelScriptActionBase action)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x509BB0", Offset = "0x5087B0", VA = "0x180509BB0")]
	public bool TryGetActionNode(int id, out LevelScriptActionBase result)
	{
		return default(bool);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x509D10", Offset = "0x508910", VA = "0x180509D10")]
	public bool TryGetNode(int id, out LevelScriptNodeBase result)
	{
		return default(bool);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x509C40", Offset = "0x508840", VA = "0x180509C40")]
	public bool TryGetHeaderNode(int id, out ActionHeader result)
	{
		return default(bool);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x6000079")]
	public bool TryGetGetterNode<T>(int id, out PureGetter<T> result)
	{
		return default(bool);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x508F40", Offset = "0x507B40", VA = "0x180508F40")]
	public bool ContainsActionNode(int id)
	{
		return default(bool);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x5094D0", Offset = "0x5080D0", VA = "0x1805094D0")]
	public void RegisterTriggerFromLevelScript()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x509DA0", Offset = "0x5089A0", VA = "0x180509DA0")]
	public LevelScriptRuntime()
	{
	}

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x0")]
	private static uint s_globalCounter;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<int, LevelScriptNodeBase> nodeMap;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, ActionHeader> headerMap;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, LevelScriptActionBase> actionMap;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, GetterNodeBase> getterMap;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x38")]
	public List<ObjectPtr<EventActionTrigger>> triggerList;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x40")]
	public ActionContext actionContext;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x48")]
	private LevelScriptData levelScriptData;
}

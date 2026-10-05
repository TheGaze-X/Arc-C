using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021FE RID: 8702
	[Token(Token = "0x20021FE")]
	[SelectionBase]
	public abstract class Entity : BObject, IHotfixable, IComparable<Entity>
	{
		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600D9FA RID: 55802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9FB RID: 55803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AF7")]
		public string id
		{
			[Token(Token = "0x600D9FA")]
			[Address(RVA = "0x3608C00", Offset = "0x3607800", VA = "0x183608C00", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D9FB")]
			[Address(RVA = "0x360CF60", Offset = "0x360BB60", VA = "0x18360CF60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9FD RID: 55805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AF8")]
		public string tmplId
		{
			[Token(Token = "0x600D9FC")]
			[Address(RVA = "0x360C530", Offset = "0x360B130", VA = "0x18360C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D9FD")]
			[Address(RVA = "0x360D5C0", Offset = "0x360C1C0", VA = "0x18360D5C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600D9FE RID: 55806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001AF9")]
		public string realId
		{
			[Token(Token = "0x600D9FE")]
			[Address(RVA = "0x360BA90", Offset = "0x360A690", VA = "0x18360BA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600D9FF RID: 55807 RVA: 0x0004F290 File Offset: 0x0004D490
		[Token(Token = "0x17001AFA")]
		public virtual bool isMine
		{
			[Token(Token = "0x600D9FF")]
			[Address(RVA = "0x3609C60", Offset = "0x3608860", VA = "0x183609C60", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600DA00 RID: 55808 RVA: 0x0004F2A8 File Offset: 0x0004D4A8
		[Token(Token = "0x17001AFB")]
		public virtual bool alive
		{
			[Token(Token = "0x600DA00")]
			[Address(RVA = "0x3605BE0", Offset = "0x36047E0", VA = "0x183605BE0", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600DA01 RID: 55809 RVA: 0x0004F2C0 File Offset: 0x0004D4C0
		[Token(Token = "0x17001AFC")]
		public virtual bool aliveOrDying
		{
			[Token(Token = "0x600DA01")]
			[Address(RVA = "0x3605AD0", Offset = "0x36046D0", VA = "0x183605AD0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600DA02 RID: 55810 RVA: 0x0004F2D8 File Offset: 0x0004D4D8
		[Token(Token = "0x17001AFD")]
		public virtual bool aliveOrReborn
		{
			[Token(Token = "0x600DA02")]
			[Address(RVA = "0x3605B60", Offset = "0x3604760", VA = "0x183605B60", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600DA03 RID: 55811 RVA: 0x0004F2F0 File Offset: 0x0004D4F0
		[Token(Token = "0x17001AFE")]
		public bool isStateRunning
		{
			[Token(Token = "0x600DA03")]
			[Address(RVA = "0x360A3B0", Offset = "0x3608FB0", VA = "0x18360A3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600DA04 RID: 55812 RVA: 0x0004F308 File Offset: 0x0004D508
		[Token(Token = "0x17001AFF")]
		public int currentStateId
		{
			[Token(Token = "0x600DA04")]
			[Address(RVA = "0x3606C60", Offset = "0x3605860", VA = "0x183606C60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x0600DA05 RID: 55813 RVA: 0x0004F320 File Offset: 0x0004D520
		[Token(Token = "0x17001B00")]
		public bool hpIsFull
		{
			[Token(Token = "0x600DA05")]
			[Address(RVA = "0x36089D0", Offset = "0x36075D0", VA = "0x1836089D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x0004F338 File Offset: 0x0004D538
		[Token(Token = "0x17001B01")]
		public bool epIsFull
		{
			[Token(Token = "0x600DA06")]
			[Address(RVA = "0x3607480", Offset = "0x3606080", VA = "0x183607480", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x0600DA07 RID: 55815 RVA: 0x0004F350 File Offset: 0x0004D550
		[Token(Token = "0x17001B02")]
		public bool isInEpBreakRecovery
		{
			[Token(Token = "0x600DA07")]
			[Address(RVA = "0x36099E0", Offset = "0x36085E0", VA = "0x1836099E0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x0600DA08 RID: 55816 RVA: 0x0004F368 File Offset: 0x0004D568
		[Token(Token = "0x17001B03")]
		public ElementType epRecoveryType
		{
			[Token(Token = "0x600DA08")]
			[Address(RVA = "0x36075F0", Offset = "0x36061F0", VA = "0x1836075F0")]
			get
			{
				return ElementType.NONE;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600DA09 RID: 55817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B04")]
		public Attributes attributes
		{
			[Token(Token = "0x600DA09")]
			[Address(RVA = "0x3605FB0", Offset = "0x3604BB0", VA = "0x183605FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B05")]
		public EventPool<Entity.Event> eventPool
		{
			[Token(Token = "0x600DA0A")]
			[Address(RVA = "0x36079F0", Offset = "0x36065F0", VA = "0x1836079F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600DA0B RID: 55819 RVA: 0x0004F380 File Offset: 0x0004D580
		// (set) Token: 0x0600DA0C RID: 55820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B06")]
		public Entity.FinishReason finishReason
		{
			[Token(Token = "0x600DA0B")]
			[Address(RVA = "0x3607F00", Offset = "0x3606B00", VA = "0x183607F00")]
			[CompilerGenerated]
			get
			{
				return Entity.FinishReason.NONE;
			}
			[Token(Token = "0x600DA0C")]
			[Address(RVA = "0x360CE10", Offset = "0x360BA10", VA = "0x18360CE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B07")]
		public Context context
		{
			[Token(Token = "0x600DA0D")]
			[Address(RVA = "0x3606B30", Offset = "0x3605730", VA = "0x183606B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x0004F398 File Offset: 0x0004D598
		[Token(Token = "0x17001B08")]
		public override Vector2 faceTo
		{
			[Token(Token = "0x600DA0E")]
			[Address(RVA = "0x3607D50", Offset = "0x3606950", VA = "0x183607D50", Slot = "10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x0600DA0F RID: 55823 RVA: 0x0004F3B0 File Offset: 0x0004D5B0
		[Token(Token = "0x17001B09")]
		public SharedConsts.Direction faceDirection
		{
			[Token(Token = "0x600DA0F")]
			[Address(RVA = "0x3607A70", Offset = "0x3606670", VA = "0x183607A70")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x0600DA10 RID: 55824 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		[Token(Token = "0x17001B0A")]
		public virtual int faceSign
		{
			[Token(Token = "0x600DA10")]
			[Address(RVA = "0x3607BE0", Offset = "0x36067E0", VA = "0x183607BE0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
		[Token(Token = "0x17001B0B")]
		public Vector2 faceVector
		{
			[Token(Token = "0x600DA11")]
			[Address(RVA = "0x3607DE0", Offset = "0x36069E0", VA = "0x183607DE0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		[Token(Token = "0x17001B0C")]
		public virtual bool faceToBack
		{
			[Token(Token = "0x600DA12")]
			[Address(RVA = "0x3607C70", Offset = "0x3606870", VA = "0x183607C70", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x0004F410 File Offset: 0x0004D610
		[Token(Token = "0x17001B0D")]
		public virtual bool faceToDown
		{
			[Token(Token = "0x600DA13")]
			[Address(RVA = "0x3607CE0", Offset = "0x36068E0", VA = "0x183607CE0", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600DA14 RID: 55828
		[Token(Token = "0x17001B0E")]
		public abstract FP hatred { [Token(Token = "0x600DA14")] get; }

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600DA15 RID: 55829
		[Token(Token = "0x17001B0F")]
		public abstract EntityCategory category { [Token(Token = "0x600DA15")] get; }

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x0004F428 File Offset: 0x0004D628
		// (set) Token: 0x0600DA17 RID: 55831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B10")]
		public MotionMode pathMotionMode
		{
			[Token(Token = "0x600DA16")]
			[Address(RVA = "0x360B990", Offset = "0x360A590", VA = "0x18360B990", Slot = "48")]
			[CompilerGenerated]
			get
			{
				return MotionMode.WALK;
			}
			[Token(Token = "0x600DA17")]
			[Address(RVA = "0x360D360", Offset = "0x360BF60", VA = "0x18360D360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x0600DA19 RID: 55833 RVA: 0x0004F440 File Offset: 0x0004D640
		// (set) Token: 0x0600DA18 RID: 55832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B11")]
		public MotionMode changeableMotionMode
		{
			[Token(Token = "0x600DA19")]
			[Address(RVA = "0x3606AA0", Offset = "0x36056A0", VA = "0x183606AA0")]
			get
			{
				return MotionMode.WALK;
			}
			[Token(Token = "0x600DA18")]
			[Address(RVA = "0x360CBC0", Offset = "0x360B7C0", VA = "0x18360CBC0")]
			private set
			{
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x0004F458 File Offset: 0x0004D658
		[Token(Token = "0x17001B12")]
		public MotionMode rawChangeableMotionMode
		{
			[Token(Token = "0x600DA1A")]
			[Address(RVA = "0x360BA10", Offset = "0x360A610", VA = "0x18360BA10")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600DA1B RID: 55835
		[Token(Token = "0x17001B13")]
		public abstract SourceApplyWay allApplyWay { [Token(Token = "0x600DA1B")] get; }

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x0600DA1C RID: 55836
		[Token(Token = "0x17001B14")]
		public abstract Tile rootTile { [Token(Token = "0x600DA1C")] get; }

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x0600DA1D RID: 55837
		[Token(Token = "0x17001B15")]
		public abstract Tile oldTile { [Token(Token = "0x600DA1D")] get; }

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x0600DA1E RID: 55838
		[Token(Token = "0x17001B16")]
		public abstract List<ObjectPtr<Projectile>> managedProjectiles { [Token(Token = "0x600DA1E")] get; }

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600DA1F RID: 55839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DA20 RID: 55840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B17")]
		public Tile originTile
		{
			[Token(Token = "0x600DA1F")]
			[Address(RVA = "0x360B910", Offset = "0x360A510", VA = "0x18360B910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600DA20")]
			[Address(RVA = "0x360D2C0", Offset = "0x360BEC0", VA = "0x18360D2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x0004F470 File Offset: 0x0004D670
		[Token(Token = "0x17001B18")]
		public bool isOnHighland
		{
			[Token(Token = "0x600DA21")]
			[Address(RVA = "0x3609E10", Offset = "0x3608A10", VA = "0x183609E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x0600DA22 RID: 55842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B19")]
		public Entity.SpController spController
		{
			[Token(Token = "0x600DA22")]
			[Address(RVA = "0x360BCA0", Offset = "0x360A8A0", VA = "0x18360BCA0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B1A")]
		public Entity.EPController epController
		{
			[Token(Token = "0x600DA23")]
			[Address(RVA = "0x3607370", Offset = "0x3605F70", VA = "0x183607370", Slot = "54")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B1B")]
		public Entity.ShieldUIController shieldUIController
		{
			[Token(Token = "0x600DA24")]
			[Address(RVA = "0x360BBA0", Offset = "0x360A7A0", VA = "0x18360BBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x0004F488 File Offset: 0x0004D688
		[Token(Token = "0x17001B1C")]
		public bool unfinished
		{
			[Token(Token = "0x600DA25")]
			[Address(RVA = "0x360C730", Offset = "0x360B330", VA = "0x18360C730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600DA26 RID: 55846 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
		[Token(Token = "0x17001B1D")]
		public bool isLocated
		{
			[Token(Token = "0x600DA26")]
			[Address(RVA = "0x3609BE0", Offset = "0x36087E0", VA = "0x183609BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x0600DA27 RID: 55847
		[Token(Token = "0x17001B1E")]
		public abstract FP createdTime { [Token(Token = "0x600DA27")] get; }

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		// (set) Token: 0x0600DA29 RID: 55849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B1F")]
		public int respawnCnt
		{
			[Token(Token = "0x600DA28")]
			[Address(RVA = "0x360BB30", Offset = "0x360A730", VA = "0x18360BB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600DA29")]
			[Address(RVA = "0x360D3F0", Offset = "0x360BFF0", VA = "0x18360D3F0")]
			set
			{
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600DA2A RID: 55850 RVA: 0x0004F4D0 File Offset: 0x0004D6D0
		// (set) Token: 0x0600DA2B RID: 55851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B20")]
		public SharedConsts.Direction direction
		{
			[Token(Token = "0x600DA2A")]
			[Address(RVA = "0x3607160", Offset = "0x3605D60", VA = "0x183607160", Slot = "56")]
			get
			{
				return SharedConsts.Direction.UP;
			}
			[Token(Token = "0x600DA2B")]
			[Address(RVA = "0x360CC90", Offset = "0x360B890", VA = "0x18360CC90")]
			protected set
			{
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600DA2C RID: 55852 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		[Token(Token = "0x17001B21")]
		public virtual SharedConsts.Direction faceLOrR
		{
			[Token(Token = "0x600DA2C")]
			[Address(RVA = "0x3607B30", Offset = "0x3606730", VA = "0x183607B30", Slot = "57")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B22")]
		public virtual Transform bodyTransform
		{
			[Token(Token = "0x600DA2D")]
			[Address(RVA = "0x36061E0", Offset = "0x3604DE0", VA = "0x1836061E0", Slot = "58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x0600DA2E RID: 55854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B23")]
		public virtual Transform graphicTransform
		{
			[Token(Token = "0x600DA2E")]
			[Address(RVA = "0x3608390", Offset = "0x3606F90", VA = "0x183608390", Slot = "59")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x0600DA2F RID: 55855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B24")]
		public virtual Transform graphicFootTransform
		{
			[Token(Token = "0x600DA2F")]
			[Address(RVA = "0x3608310", Offset = "0x3606F10", VA = "0x183608310", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x0600DA30 RID: 55856
		[Token(Token = "0x17001B25")]
		public abstract Transform graphicHolderTransform { [Token(Token = "0x600DA30")] get; }

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x0600DA31 RID: 55857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B26")]
		public virtual Transform directionTransform
		{
			[Token(Token = "0x600DA31")]
			[Address(RVA = "0x36070F0", Offset = "0x3605CF0", VA = "0x1836070F0", Slot = "62")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x0600DA32 RID: 55858
		// (set) Token: 0x0600DA33 RID: 55859
		[Token(Token = "0x17001B27")]
		public abstract Color color { [Token(Token = "0x600DA32")] get; [Token(Token = "0x600DA33")] protected set; }

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x0600DA34 RID: 55860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B28")]
		public string stateDebugStr
		{
			[Token(Token = "0x600DA34")]
			[Address(RVA = "0x360C240", Offset = "0x360AE40", VA = "0x18360C240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x0600DA35 RID: 55861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DA36 RID: 55862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B29")]
		public Buff.BuffContainer buffContainer
		{
			[Token(Token = "0x600DA35")]
			[Address(RVA = "0x3606260", Offset = "0x3604E60", VA = "0x183606260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600DA36")]
			[Address(RVA = "0x360CB20", Offset = "0x360B720", VA = "0x18360CB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x0600DA37 RID: 55863 RVA: 0x0004F500 File Offset: 0x0004D700
		// (set) Token: 0x0600DA38 RID: 55864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B2A")]
		public MapLayer mapLayer
		{
			[Token(Token = "0x600DA37")]
			[Address(RVA = "0x360A9A0", Offset = "0x36095A0", VA = "0x18360A9A0")]
			[CompilerGenerated]
			get
			{
				return MapLayer.LAYER_A;
			}
			[Token(Token = "0x600DA38")]
			[Address(RVA = "0x360D080", Offset = "0x360BC80", VA = "0x18360D080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x0004F518 File Offset: 0x0004D718
		[Token(Token = "0x17001B2B")]
		public bool isNotAliveAndStartFinishing
		{
			[Token(Token = "0x600DA39")]
			[Address(RVA = "0x3609D50", Offset = "0x3608950", VA = "0x183609D50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x0600DA3A RID: 55866 RVA: 0x0004F530 File Offset: 0x0004D730
		[Token(Token = "0x17001B2C")]
		protected bool startIniting
		{
			[Token(Token = "0x600DA3A")]
			[Address(RVA = "0x360C1C0", Offset = "0x360ADC0", VA = "0x18360C1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x0004F548 File Offset: 0x0004D748
		[Token(Token = "0x17001B2D")]
		protected bool canRecoverHp
		{
			[Token(Token = "0x600DA3B")]
			[Address(RVA = "0x3606510", Offset = "0x3605110", VA = "0x183606510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x0004F560 File Offset: 0x0004D760
		[Token(Token = "0x17001B2E")]
		protected bool canRecoverSp
		{
			[Token(Token = "0x600DA3C")]
			[Address(RVA = "0x36065F0", Offset = "0x36051F0", VA = "0x1836065F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x0600DA3D RID: 55869 RVA: 0x0004F578 File Offset: 0x0004D778
		[Token(Token = "0x17001B2F")]
		protected bool canRecoverEp
		{
			[Token(Token = "0x600DA3D")]
			[Address(RVA = "0x3606430", Offset = "0x3605030", VA = "0x183606430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x0004F590 File Offset: 0x0004D790
		[Token(Token = "0x17001B30")]
		public bool canUseAbility
		{
			[Token(Token = "0x600DA3E")]
			[Address(RVA = "0x36066D0", Offset = "0x36052D0", VA = "0x1836066D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
		[Token(Token = "0x17001B31")]
		public bool canUseAtkOrCbt
		{
			[Token(Token = "0x600DA3F")]
			[Address(RVA = "0x3606810", Offset = "0x3605410", VA = "0x183606810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x0600DA40 RID: 55872 RVA: 0x0004F5C0 File Offset: 0x0004D7C0
		[Token(Token = "0x17001B32")]
		public bool canMove
		{
			[Token(Token = "0x600DA40")]
			[Address(RVA = "0x36062E0", Offset = "0x3604EE0", VA = "0x1836062E0", Slot = "65")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x0600DA41 RID: 55873 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		[Token(Token = "0x17001B33")]
		public bool isSuicide
		{
			[Token(Token = "0x600DA41")]
			[Address(RVA = "0x360A4F0", Offset = "0x36090F0", VA = "0x18360A4F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x0600DA42 RID: 55874 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
		[Token(Token = "0x17001B34")]
		protected virtual float delayToRecycle
		{
			[Token(Token = "0x600DA42")]
			[Address(RVA = "0x3607080", Offset = "0x3605C80", VA = "0x183607080", Slot = "66")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x0600DA43 RID: 55875
		[Token(Token = "0x17001B35")]
		protected abstract bool isFixedRotation { [Token(Token = "0x600DA43")] get; }

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x0600DA44 RID: 55876 RVA: 0x0004F608 File Offset: 0x0004D808
		[Token(Token = "0x17001B36")]
		protected virtual int initState
		{
			[Token(Token = "0x600DA44")]
			[Address(RVA = "0x3608FF0", Offset = "0x3607BF0", VA = "0x183608FF0", Slot = "68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x0600DA45 RID: 55877 RVA: 0x0004F620 File Offset: 0x0004D820
		[Token(Token = "0x17001B37")]
		public virtual Color defaultBodyColor
		{
			[Token(Token = "0x600DA45")]
			[Address(RVA = "0x3606FB0", Offset = "0x3605BB0", VA = "0x183606FB0", Slot = "69")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x0600DA46 RID: 55878 RVA: 0x0004F638 File Offset: 0x0004D838
		// (set) Token: 0x0600DA47 RID: 55879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B38")]
		public bool shouldRenderFlag
		{
			[Token(Token = "0x600DA46")]
			[Address(RVA = "0x360BC20", Offset = "0x360A820", VA = "0x18360BC20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DA47")]
			[Address(RVA = "0x360D480", Offset = "0x360C080", VA = "0x18360D480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x0600DA48 RID: 55880 RVA: 0x0004F650 File Offset: 0x0004D850
		[Token(Token = "0x17001B39")]
		public virtual float graphicBoundRadius
		{
			[Token(Token = "0x600DA48")]
			[Address(RVA = "0x3608260", Offset = "0x3606E60", VA = "0x183608260", Slot = "70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x0600DA49 RID: 55881
		[Token(Token = "0x17001B3A")]
		public abstract Transform footPoint { [Token(Token = "0x600DA49")] get; }

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x0600DA4A RID: 55882
		[Token(Token = "0x17001B3B")]
		public abstract Transform hitPoint { [Token(Token = "0x600DA4A")] get; }

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600DA4B RID: 55883
		[Token(Token = "0x17001B3C")]
		public abstract Transform muzzlePoint { [Token(Token = "0x600DA4B")] get; }

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x0600DA4C RID: 55884
		[Token(Token = "0x17001B3D")]
		public abstract Transform headPoint { [Token(Token = "0x600DA4C")] get; }

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x0600DA4D RID: 55885
		[Token(Token = "0x17001B3E")]
		public abstract Transform uiPoint { [Token(Token = "0x600DA4D")] get; }

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B3F")]
		public virtual Transform effectTransform
		{
			[Token(Token = "0x600DA4E")]
			[Address(RVA = "0x36071E0", Offset = "0x3605DE0", VA = "0x1836071E0", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x0600DA4F RID: 55887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B40")]
		public MountPoint footMountPoint
		{
			[Token(Token = "0x600DA4F")]
			[Address(RVA = "0x3607F80", Offset = "0x3606B80", VA = "0x183607F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600DA50 RID: 55888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B41")]
		public MountPoint hitMountPoint
		{
			[Token(Token = "0x600DA50")]
			[Address(RVA = "0x36086F0", Offset = "0x36072F0", VA = "0x1836086F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B42")]
		public MountPoint muzzleMountPoint
		{
			[Token(Token = "0x600DA51")]
			[Address(RVA = "0x360B5A0", Offset = "0x360A1A0", VA = "0x18360B5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600DA52 RID: 55890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B43")]
		public MountPoint headMountPoint
		{
			[Token(Token = "0x600DA52")]
			[Address(RVA = "0x3608410", Offset = "0x3607010", VA = "0x183608410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x0600DA53 RID: 55891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B44")]
		public MountPoint uiMountPoint
		{
			[Token(Token = "0x600DA53")]
			[Address(RVA = "0x360C5B0", Offset = "0x360B1B0", VA = "0x18360C5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x0004F668 File Offset: 0x0004D868
		// (set) Token: 0x0600DA55 RID: 55893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B45")]
		public FP hp
		{
			[Token(Token = "0x600DA54")]
			[Address(RVA = "0x3608B80", Offset = "0x3607780", VA = "0x183608B80")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600DA55")]
			[Address(RVA = "0x360CEA0", Offset = "0x360BAA0", VA = "0x18360CEA0")]
			protected set
			{
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x0600DA56 RID: 55894 RVA: 0x0004F680 File Offset: 0x0004D880
		// (set) Token: 0x0600DA57 RID: 55895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B46")]
		public FP es
		{
			[Token(Token = "0x600DA56")]
			[Address(RVA = "0x3607970", Offset = "0x3606570", VA = "0x183607970")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600DA57")]
			[Address(RVA = "0x360CD60", Offset = "0x360B960", VA = "0x18360CD60")]
			protected set
			{
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x0004F698 File Offset: 0x0004D898
		[Token(Token = "0x17001B47")]
		public FP hpRatio
		{
			[Token(Token = "0x600DA58")]
			[Address(RVA = "0x3608A90", Offset = "0x3607690", VA = "0x183608A90")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x0600DA59 RID: 55897 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		// (set) Token: 0x0600DA5A RID: 55898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B48")]
		public FP sp
		{
			[Token(Token = "0x600DA59")]
			[Address(RVA = "0x360C120", Offset = "0x360AD20", VA = "0x18360C120")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600DA5A")]
			[Address(RVA = "0x360D510", Offset = "0x360C110", VA = "0x18360D510")]
			protected set
			{
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		// (set) Token: 0x0600DA5C RID: 55900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B49")]
		public int maxSp
		{
			[Token(Token = "0x600DA5B")]
			[Address(RVA = "0x360AF90", Offset = "0x3609B90", VA = "0x18360AF90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600DA5C")]
			[Address(RVA = "0x360D1A0", Offset = "0x360BDA0", VA = "0x18360D1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x0600DA5D RID: 55901 RVA: 0x0004F6E0 File Offset: 0x0004D8E0
		[Token(Token = "0x17001B4A")]
		public FP spRatio
		{
			[Token(Token = "0x600DA5D")]
			[Address(RVA = "0x360BDB0", Offset = "0x360A9B0", VA = "0x18360BDB0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600DA5E RID: 55902 RVA: 0x0004F6F8 File Offset: 0x0004D8F8
		// (set) Token: 0x0600DA5F RID: 55903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B4B")]
		public FP minusHp
		{
			[Token(Token = "0x600DA5E")]
			[Address(RVA = "0x360B3D0", Offset = "0x3609FD0", VA = "0x18360B3D0")]
			[CompilerGenerated]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600DA5F")]
			[Address(RVA = "0x360D230", Offset = "0x360BE30", VA = "0x18360D230")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600DA60 RID: 55904 RVA: 0x0004F710 File Offset: 0x0004D910
		// (set) Token: 0x0600DA61 RID: 55905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B4C")]
		public FP maxMinusHpRatio
		{
			[Token(Token = "0x600DA60")]
			[Address(RVA = "0x360ADF0", Offset = "0x36099F0", VA = "0x18360ADF0")]
			[CompilerGenerated]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600DA61")]
			[Address(RVA = "0x360D110", Offset = "0x360BD10", VA = "0x18360D110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600DA62 RID: 55906 RVA: 0x0004F728 File Offset: 0x0004D928
		[Token(Token = "0x17001B4D")]
		public FP maxMinusHp
		{
			[Token(Token = "0x600DA62")]
			[Address(RVA = "0x360AE70", Offset = "0x3609A70", VA = "0x18360AE70")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x0600DA63 RID: 55907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001B4E")]
		public FP[] epArray
		{
			[Token(Token = "0x600DA63")]
			[Address(RVA = "0x3607260", Offset = "0x3605E60", VA = "0x183607260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x0004F740 File Offset: 0x0004D940
		[Token(Token = "0x17001B4F")]
		public ElementType minEpType
		{
			[Token(Token = "0x600DA64")]
			[Address(RVA = "0x360B1E0", Offset = "0x3609DE0", VA = "0x18360B1E0")]
			get
			{
				return ElementType.NONE;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x0600DA65 RID: 55909 RVA: 0x0004F758 File Offset: 0x0004D958
		[Token(Token = "0x17001B50")]
		public FP minEpRatio
		{
			[Token(Token = "0x600DA65")]
			[Address(RVA = "0x360B010", Offset = "0x3609C10", VA = "0x18360B010")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x0600DA66 RID: 55910 RVA: 0x0004F770 File Offset: 0x0004D970
		[Token(Token = "0x17001B51")]
		public virtual FP maxEp
		{
			[Token(Token = "0x600DA66")]
			[Address(RVA = "0x360AC30", Offset = "0x3609830", VA = "0x18360AC30", Slot = "77")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x0004F788 File Offset: 0x0004D988
		[Token(Token = "0x17001B52")]
		public FP attackTime
		{
			[Token(Token = "0x600DA67")]
			[Address(RVA = "0x3605E00", Offset = "0x3604A00", VA = "0x183605E00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x0004F7A0 File Offset: 0x0004D9A0
		[Token(Token = "0x17001B53")]
		public FP maxHp
		{
			[Token(Token = "0x600DA68")]
			[Address(RVA = "0x360AD60", Offset = "0x3609960", VA = "0x18360AD60", Slot = "78")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x0600DA69 RID: 55913 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		[Token(Token = "0x17001B54")]
		public virtual FP maxEs
		{
			[Token(Token = "0x600DA69")]
			[Address(RVA = "0x360ACC0", Offset = "0x36098C0", VA = "0x18360ACC0", Slot = "79")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		[Token(Token = "0x17001B55")]
		public virtual FP esToShow
		{
			[Token(Token = "0x600DA6A")]
			[Address(RVA = "0x36078F0", Offset = "0x36064F0", VA = "0x1836078F0", Slot = "80")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x0600DA6B RID: 55915 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
		[Token(Token = "0x17001B56")]
		public FP esRatioToShow
		{
			[Token(Token = "0x600DA6B")]
			[Address(RVA = "0x3607710", Offset = "0x3606310", VA = "0x183607710")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x0600DA6C RID: 55916 RVA: 0x0004F800 File Offset: 0x0004DA00
		[Token(Token = "0x17001B57")]
		public FP atk
		{
			[Token(Token = "0x600DA6C")]
			[Address(RVA = "0x3605CE0", Offset = "0x36048E0", VA = "0x183605CE0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x0600DA6D RID: 55917 RVA: 0x0004F818 File Offset: 0x0004DA18
		[Token(Token = "0x17001B58")]
		public FP def
		{
			[Token(Token = "0x600DA6D")]
			[Address(RVA = "0x3606F20", Offset = "0x3605B20", VA = "0x183606F20")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x0600DA6E RID: 55918 RVA: 0x0004F830 File Offset: 0x0004DA30
		[Token(Token = "0x17001B59")]
		public FP magicResistance
		{
			[Token(Token = "0x600DA6E")]
			[Address(RVA = "0x360A910", Offset = "0x3609510", VA = "0x18360A910")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x0004F848 File Offset: 0x0004DA48
		[Token(Token = "0x17001B5A")]
		public FP epDamageResistance
		{
			[Token(Token = "0x600DA6F")]
			[Address(RVA = "0x36073F0", Offset = "0x3605FF0", VA = "0x1836073F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x0004F860 File Offset: 0x0004DA60
		[Token(Token = "0x17001B5B")]
		public FP epResistance
		{
			[Token(Token = "0x600DA70")]
			[Address(RVA = "0x3607680", Offset = "0x3606280", VA = "0x183607680")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x0004F878 File Offset: 0x0004DA78
		[Token(Token = "0x17001B5C")]
		public FP damageHitratePhysical
		{
			[Token(Token = "0x600DA71")]
			[Address(RVA = "0x3606D70", Offset = "0x3605970", VA = "0x183606D70")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x0004F890 File Offset: 0x0004DA90
		[Token(Token = "0x17001B5D")]
		public FP damageHitrateMagical
		{
			[Token(Token = "0x600DA72")]
			[Address(RVA = "0x3606CE0", Offset = "0x36058E0", VA = "0x183606CE0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x0600DA73 RID: 55923 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		[Token(Token = "0x17001B5E")]
		public int cost
		{
			[Token(Token = "0x600DA73")]
			[Address(RVA = "0x3606BD0", Offset = "0x36057D0", VA = "0x183606BD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x0004F8C0 File Offset: 0x0004DAC0
		[Token(Token = "0x17001B5F")]
		public virtual int blockCnt
		{
			[Token(Token = "0x600DA74")]
			[Address(RVA = "0x3606150", Offset = "0x3604D50", VA = "0x183606150", Slot = "81")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x0004F8D8 File Offset: 0x0004DAD8
		[Token(Token = "0x17001B60")]
		public float moveSpeed
		{
			[Token(Token = "0x600DA75")]
			[Address(RVA = "0x360B450", Offset = "0x360A050", VA = "0x18360B450", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x0004F8F0 File Offset: 0x0004DAF0
		[Token(Token = "0x17001B61")]
		public FP attackSpeed
		{
			[Token(Token = "0x600DA76")]
			[Address(RVA = "0x3605D70", Offset = "0x3604970", VA = "0x183605D70")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x0004F908 File Offset: 0x0004DB08
		[Token(Token = "0x17001B62")]
		public FP baseAttackTime
		{
			[Token(Token = "0x600DA77")]
			[Address(RVA = "0x3606030", Offset = "0x3604C30", VA = "0x183606030")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600DA78 RID: 55928 RVA: 0x0004F920 File Offset: 0x0004DB20
		[Token(Token = "0x17001B63")]
		public FP defPenetrateRatio
		{
			[Token(Token = "0x600DA78")]
			[Address(RVA = "0x3606E90", Offset = "0x3605A90", VA = "0x183606E90")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x0600DA79 RID: 55929 RVA: 0x0004F938 File Offset: 0x0004DB38
		[Token(Token = "0x17001B64")]
		public FP defPenetrateFixed
		{
			[Token(Token = "0x600DA79")]
			[Address(RVA = "0x3606E00", Offset = "0x3605A00", VA = "0x183606E00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x0600DA7A RID: 55930 RVA: 0x0004F950 File Offset: 0x0004DB50
		[Token(Token = "0x17001B65")]
		public FP magicResistPenetrate
		{
			[Token(Token = "0x600DA7A")]
			[Address(RVA = "0x360A880", Offset = "0x3609480", VA = "0x18360A880")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x0600DA7B RID: 55931 RVA: 0x0004F968 File Offset: 0x0004DB68
		[Token(Token = "0x17001B66")]
		public FP magicResistPenetrateFixed
		{
			[Token(Token = "0x600DA7B")]
			[Address(RVA = "0x360A7F0", Offset = "0x36093F0", VA = "0x18360A7F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x0004F980 File Offset: 0x0004DB80
		[Token(Token = "0x17001B67")]
		public FP oneMinusStatusResistance
		{
			[Token(Token = "0x600DA7C")]
			[Address(RVA = "0x360B880", Offset = "0x360A480", VA = "0x18360B880")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x0004F998 File Offset: 0x0004DB98
		[Token(Token = "0x17001B68")]
		public FP sumUpHpRecoveryPerSec
		{
			[Token(Token = "0x600DA7D")]
			[Address(RVA = "0x360C380", Offset = "0x360AF80", VA = "0x18360C380")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600DA7E RID: 55934 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
		[Token(Token = "0x17001B69")]
		public FP spRecoveryPerSec
		{
			[Token(Token = "0x600DA7E")]
			[Address(RVA = "0x360BFD0", Offset = "0x360ABD0", VA = "0x18360BFD0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600DA7F RID: 55935 RVA: 0x0004F9C8 File Offset: 0x0004DBC8
		[Token(Token = "0x17001B6A")]
		public FP sumUpEpRecoveryPerSec
		{
			[Token(Token = "0x600DA7F")]
			[Address(RVA = "0x360C2F0", Offset = "0x360AEF0", VA = "0x18360C2F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x0600DA80 RID: 55936 RVA: 0x0004F9E0 File Offset: 0x0004DBE0
		[Token(Token = "0x17001B6B")]
		public FP abilityRangeForwardExtend
		{
			[Token(Token = "0x600DA80")]
			[Address(RVA = "0x3605A40", Offset = "0x3604640", VA = "0x183605A40")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600DA81 RID: 55937 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
		[Token(Token = "0x17001B6C")]
		public int tauntLevel
		{
			[Token(Token = "0x600DA81")]
			[Address(RVA = "0x360C4A0", Offset = "0x360B0A0", VA = "0x18360C4A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x0004FA10 File Offset: 0x0004DC10
		[Token(Token = "0x17001B6D")]
		public int baseForceLevel
		{
			[Token(Token = "0x600DA82")]
			[Address(RVA = "0x36060C0", Offset = "0x3604CC0", VA = "0x1836060C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x0004FA28 File Offset: 0x0004DC28
		[Token(Token = "0x17001B6E")]
		public int massLevel
		{
			[Token(Token = "0x600DA83")]
			[Address(RVA = "0x360AA20", Offset = "0x3609620", VA = "0x18360AA20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x0600DA84 RID: 55940 RVA: 0x0004FA40 File Offset: 0x0004DC40
		[Token(Token = "0x17001B6F")]
		public FP epBreakRecoverSpeed
		{
			[Token(Token = "0x600DA84")]
			[Address(RVA = "0x36072E0", Offset = "0x3605EE0", VA = "0x1836072E0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x0004FA58 File Offset: 0x0004DC58
		[Token(Token = "0x17001B70")]
		public bool isStunned
		{
			[Token(Token = "0x600DA85")]
			[Address(RVA = "0x360A430", Offset = "0x3609030", VA = "0x18360A430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x0600DA86 RID: 55942 RVA: 0x0004FA70 File Offset: 0x0004DC70
		[Token(Token = "0x17001B71")]
		public bool isCold
		{
			[Token(Token = "0x600DA86")]
			[Address(RVA = "0x3609330", Offset = "0x3607F30", VA = "0x183609330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x0004FA88 File Offset: 0x0004DC88
		[Token(Token = "0x17001B72")]
		public bool isFrozen
		{
			[Token(Token = "0x600DA87")]
			[Address(RVA = "0x3609710", Offset = "0x3608310", VA = "0x183609710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600DA88 RID: 55944 RVA: 0x0004FAA0 File Offset: 0x0004DCA0
		[Token(Token = "0x17001B73")]
		public bool isDoze
		{
			[Token(Token = "0x600DA88")]
			[Address(RVA = "0x3609530", Offset = "0x3608130", VA = "0x183609530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600DA89 RID: 55945 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
		[Token(Token = "0x17001B74")]
		public bool isLevitate
		{
			[Token(Token = "0x600DA89")]
			[Address(RVA = "0x3609B50", Offset = "0x3608750", VA = "0x183609B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600DA8A RID: 55946 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		[Token(Token = "0x17001B75")]
		protected bool isUnmovable
		{
			[Token(Token = "0x600DA8A")]
			[Address(RVA = "0x360A730", Offset = "0x3609330", VA = "0x18360A730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		[Token(Token = "0x17001B76")]
		public bool isSleeping
		{
			[Token(Token = "0x600DA8B")]
			[Address(RVA = "0x360A320", Offset = "0x3608F20", VA = "0x18360A320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x0600DA8C RID: 55948 RVA: 0x0004FB00 File Offset: 0x0004DD00
		[Token(Token = "0x17001B77")]
		public bool spRecoverStopped
		{
			[Token(Token = "0x600DA8C")]
			[Address(RVA = "0x360BF40", Offset = "0x360AB40", VA = "0x18360BF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600DA8D RID: 55949 RVA: 0x0004FB18 File Offset: 0x0004DD18
		[Token(Token = "0x17001B78")]
		public bool spModifyStopped
		{
			[Token(Token = "0x600DA8D")]
			[Address(RVA = "0x360BD20", Offset = "0x360A920", VA = "0x18360BD20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600DA8E RID: 55950 RVA: 0x0004FB30 File Offset: 0x0004DD30
		[Token(Token = "0x17001B79")]
		public bool isMotionTargetFree
		{
			[Token(Token = "0x600DA8E")]
			[Address(RVA = "0x3609CD0", Offset = "0x36088D0", VA = "0x183609CD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x0600DA8F RID: 55951 RVA: 0x0004FB48 File Offset: 0x0004DD48
		[Token(Token = "0x17001B7A")]
		public FP spRecoverRatio
		{
			[Token(Token = "0x600DA8F")]
			[Address(RVA = "0x360BEB0", Offset = "0x360AAB0", VA = "0x18360BEB0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x0600DA90 RID: 55952 RVA: 0x0004FB60 File Offset: 0x0004DD60
		[Token(Token = "0x17001B7B")]
		public bool isTargetFree
		{
			[Token(Token = "0x600DA90")]
			[Address(RVA = "0x360A570", Offset = "0x3609170", VA = "0x18360A570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x0600DA91 RID: 55953 RVA: 0x0004FB78 File Offset: 0x0004DD78
		[Token(Token = "0x17001B7C")]
		public bool isFeared
		{
			[Token(Token = "0x600DA91")]
			[Address(RVA = "0x3609650", Offset = "0x3608250", VA = "0x183609650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x0004FB90 File Offset: 0x0004DD90
		[Token(Token = "0x17001B7D")]
		public bool isPalsy
		{
			[Token(Token = "0x600DA92")]
			[Address(RVA = "0x3609F30", Offset = "0x3608B30", VA = "0x183609F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x0600DA93 RID: 55955 RVA: 0x0004FBA8 File Offset: 0x0004DDA8
		[Token(Token = "0x17001B7E")]
		public bool isPalsying
		{
			[Token(Token = "0x600DA93")]
			[Address(RVA = "0x3609FC0", Offset = "0x3608BC0", VA = "0x183609FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x0004FBC0 File Offset: 0x0004DDC0
		[Token(Token = "0x17001B7F")]
		public bool isAttracted
		{
			[Token(Token = "0x600DA94")]
			[Address(RVA = "0x36090F0", Offset = "0x3607CF0", VA = "0x1836090F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		[Token(Token = "0x600DA95")]
		[Address(RVA = "0x35FAB90", Offset = "0x35F9790", VA = "0x1835FAB90")]
		public bool IsStillTargetFreeWithImmuneFlag(AbnormalFlag immuneFlag, AbnormalCombo immuneCombo)
		{
			return default(bool);
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x0004FBF0 File Offset: 0x0004DDF0
		[Token(Token = "0x600DA96")]
		[Address(RVA = "0x360C9D0", Offset = "0x360B5D0", VA = "0x18360C9D0")]
		public bool isTargetFreeWithImmuneFlag(AbnormalFlag immuneFlag, AbnormalCombo immuneCombo)
		{
			return default(bool);
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x0004FC08 File Offset: 0x0004DE08
		[Token(Token = "0x600DA97")]
		[Address(RVA = "0x360C880", Offset = "0x360B480", VA = "0x18360C880", Slot = "83")]
		public virtual bool isStillMotionTargetFreeWithImmuneFlag(AbnormalFlag immuneFlag, AbnormalCombo immuneCombo, MotionMode sourceMotionMode)
		{
			return default(bool);
		}

		// Token: 0x0600DA98 RID: 55960 RVA: 0x0004FC20 File Offset: 0x0004DE20
		[Token(Token = "0x600DA98")]
		[Address(RVA = "0x360C7B0", Offset = "0x360B3B0", VA = "0x18360C7B0")]
		public bool isMotionTargetFreeWithImmuneFlag(AbnormalFlag immuneFlag, AbnormalCombo immuneCombo)
		{
			return default(bool);
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x0004FC38 File Offset: 0x0004DE38
		[Token(Token = "0x17001B80")]
		public bool isBlockFree
		{
			[Token(Token = "0x600DA99")]
			[Address(RVA = "0x3609180", Offset = "0x3607D80", VA = "0x183609180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x0004FC50 File Offset: 0x0004DE50
		[Token(Token = "0x17001B81")]
		public virtual bool isHidden
		{
			[Token(Token = "0x600DA9A")]
			[Address(RVA = "0x3609920", Offset = "0x3608520", VA = "0x183609920", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x0004FC68 File Offset: 0x0004DE68
		[Token(Token = "0x17001B82")]
		public virtual bool isHiddenToAlly
		{
			[Token(Token = "0x600DA9B")]
			[Address(RVA = "0x3609830", Offset = "0x3608430", VA = "0x183609830", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x0600DA9C RID: 55964 RVA: 0x0004FC80 File Offset: 0x0004DE80
		[Token(Token = "0x17001B83")]
		public bool isInvincible
		{
			[Token(Token = "0x600DA9C")]
			[Address(RVA = "0x3609AA0", Offset = "0x36086A0", VA = "0x183609AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x0004FC98 File Offset: 0x0004DE98
		[Token(Token = "0x17001B84")]
		public bool isUndeadable
		{
			[Token(Token = "0x600DA9D")]
			[Address(RVA = "0x360A6A0", Offset = "0x36092A0", VA = "0x18360A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
		[Token(Token = "0x17001B85")]
		public bool isHealFree
		{
			[Token(Token = "0x600DA9E")]
			[Address(RVA = "0x36097A0", Offset = "0x36083A0", VA = "0x1836097A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x0004FCC8 File Offset: 0x0004DEC8
		[Token(Token = "0x17001B86")]
		public bool isAllyTargetFree
		{
			[Token(Token = "0x600DA9F")]
			[Address(RVA = "0x3609060", Offset = "0x3607C60", VA = "0x183609060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x0600DAA0 RID: 55968 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		[Token(Token = "0x17001B87")]
		public bool isEPFreeAll
		{
			[Token(Token = "0x600DAA0")]
			[Address(RVA = "0x36095C0", Offset = "0x36081C0", VA = "0x1836095C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		[Token(Token = "0x17001B88")]
		public bool isUnbalanceImmune
		{
			[Token(Token = "0x600DAA1")]
			[Address(RVA = "0x360A610", Offset = "0x3609210", VA = "0x18360A610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x0600DAA2 RID: 55970 RVA: 0x0004FD10 File Offset: 0x0004DF10
		[Token(Token = "0x17001B89")]
		public bool isDisarmed
		{
			[Token(Token = "0x600DAA2")]
			[Address(RVA = "0x3609440", Offset = "0x3608040", VA = "0x183609440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x0600DAA3 RID: 55971 RVA: 0x0004FD28 File Offset: 0x0004DF28
		[Token(Token = "0x17001B8A")]
		public bool isSilenced
		{
			[Token(Token = "0x600DAA3")]
			[Address(RVA = "0x360A160", Offset = "0x3608D60", VA = "0x18360A160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x0600DAA4 RID: 55972 RVA: 0x0004FD40 File Offset: 0x0004DF40
		[Token(Token = "0x17001B8B")]
		public bool isSkillActivatable
		{
			[Token(Token = "0x600DAA4")]
			[Address(RVA = "0x360A280", Offset = "0x3608E80", VA = "0x18360A280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x0004FD58 File Offset: 0x0004DF58
		[Token(Token = "0x17001B8C")]
		public bool isSkillActivatableInAbnormal
		{
			[Token(Token = "0x600DAA5")]
			[Address(RVA = "0x360A1F0", Offset = "0x3608DF0", VA = "0x18360A1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x0600DAA6 RID: 55974 RVA: 0x0004FD70 File Offset: 0x0004DF70
		[Token(Token = "0x17001B8D")]
		public bool isSilencedOrStunned
		{
			[Token(Token = "0x600DAA6")]
			[Address(RVA = "0x360A050", Offset = "0x3608C50", VA = "0x18360A050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x0600DAA7 RID: 55975 RVA: 0x0004FD88 File Offset: 0x0004DF88
		[Token(Token = "0x17001B8E")]
		public bool inAbnormalState
		{
			[Token(Token = "0x600DAA7")]
			[Address(RVA = "0x3608E00", Offset = "0x3607A00", VA = "0x183608E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x0600DAA8 RID: 55976 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
		[Token(Token = "0x17001B8F")]
		public bool inAbnormalStateButNotDoze
		{
			[Token(Token = "0x600DAA8")]
			[Address(RVA = "0x3608C80", Offset = "0x3607880", VA = "0x183608C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
		[Token(Token = "0x17001B90")]
		public bool isCamouflage
		{
			[Token(Token = "0x600DAA9")]
			[Address(RVA = "0x3609270", Offset = "0x3607E70", VA = "0x183609270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x0600DAAA RID: 55978 RVA: 0x0004FDD0 File Offset: 0x0004DFD0
		[Token(Token = "0x17001B91")]
		public int maxDeployCnt
		{
			[Token(Token = "0x600DAAA")]
			[Address(RVA = "0x360AAB0", Offset = "0x36096B0", VA = "0x18360AAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x0004FDE8 File Offset: 0x0004DFE8
		[Token(Token = "0x17001B92")]
		public int maxDeployStackCnt
		{
			[Token(Token = "0x600DAAB")]
			[Address(RVA = "0x360AB70", Offset = "0x3609770", VA = "0x18360AB70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x0600DAAC RID: 55980 RVA: 0x0004FE00 File Offset: 0x0004E000
		// (set) Token: 0x0600DAAD RID: 55981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001B93")]
		public bool isDialogTarget
		{
			[Token(Token = "0x600DAAC")]
			[Address(RVA = "0x36093C0", Offset = "0x3607FC0", VA = "0x1836093C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DAAD")]
			[Address(RVA = "0x360CFF0", Offset = "0x360BBF0", VA = "0x18360CFF0")]
			set
			{
			}
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAAE")]
		[Address(RVA = "0x35F79B0", Offset = "0x35F65B0", VA = "0x1835F79B0")]
		public void FaceToDirection(bool force = false, bool idle = false)
		{
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAAF")]
		[Address(RVA = "0x35F7B50", Offset = "0x35F6750", VA = "0x1835F7B50")]
		public void FaceToFront(bool force = false, bool idle = false)
		{
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAB0")]
		[Address(RVA = "0x35F77D0", Offset = "0x35F63D0", VA = "0x1835F77D0")]
		public void FaceToBack(bool force = false, bool idle = false)
		{
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAB1")]
		[Address(RVA = "0x35F7E50", Offset = "0x35F6A50", VA = "0x1835F7E50")]
		public void FaceTo(Vector2 direction, bool force = false, bool idle = false)
		{
		}

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAB2")]
		[Address(RVA = "0x35F7D30", Offset = "0x35F6930", VA = "0x1835F7D30")]
		public void FaceToTarget(Vector2 targetMapPos, bool force = false, bool idle = false)
		{
		}

		// Token: 0x0600DAB3 RID: 55987 RVA: 0x0004FE18 File Offset: 0x0004E018
		[Token(Token = "0x600DAB3")]
		[Address(RVA = "0x3600D60", Offset = "0x35FF960", VA = "0x183600D60")]
		public bool SetBodyDirection(Vector2 direction, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DAB4 RID: 55988 RVA: 0x0004FE30 File Offset: 0x0004E030
		[Token(Token = "0x600DAB4")]
		[Address(RVA = "0x3600E50", Offset = "0x35FFA50", VA = "0x183600E50")]
		public bool SetBodyDirection(SharedConsts.Direction direction, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DAB5 RID: 55989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAB5")]
		[Address(RVA = "0x3600C80", Offset = "0x35FF880", VA = "0x183600C80", Slot = "86")]
		public virtual void SetBodyAndFaceDirection(Vector2 direction, bool force = false)
		{
		}

		// Token: 0x0600DAB6 RID: 55990
		[Token(Token = "0x600DAB6")]
		public abstract void SetGraphicHolderHeightOffset(FP heightOffset, FP duration, string audioSignalOnStop, bool useGlobalPos);

		// Token: 0x0600DAB7 RID: 55991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAB7")]
		[Address(RVA = "0x35F9480", Offset = "0x35F8080", VA = "0x1835F9480", Slot = "88")]
		public virtual EffectReplacePair[] GetEffectReplacePairs()
		{
			return null;
		}

		// Token: 0x0600DAB8 RID: 55992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAB8")]
		[Address(RVA = "0x35F9700", Offset = "0x35F8300", VA = "0x1835F9700", Slot = "89")]
		public virtual MountPoint GetMountPoint(Entity.MountPointType mountPoint)
		{
			return null;
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAB9")]
		[Address(RVA = "0x35F94F0", Offset = "0x35F80F0", VA = "0x1835F94F0", Slot = "90")]
		public virtual MountPoint GetMountPointForEffect(Entity.MountPointType mountPoint)
		{
			return null;
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DABA")]
		[Address(RVA = "0x35F4400", Offset = "0x35F3000", VA = "0x1835F4400")]
		public Buff AddBuff(BuffConfig config, Entity source, Ability ability, Blackboard extraBlackboard, [Optional] Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile, [Optional] string customOverrideEffectKey)
		{
			return null;
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DABB")]
		[Address(RVA = "0x35F4560", Offset = "0x35F3160", VA = "0x1835F4560")]
		public Buff AddBuff(BuffData data, Entity source, Ability ability, Blackboard extraBlackboard, [Optional] Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile, [Optional] string customOverrideEffectKey)
		{
			return null;
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DABC")]
		[Address(RVA = "0x35F4B80", Offset = "0x35F3780", VA = "0x1835F4B80")]
		public uint[] AddBuffs(IList<BuffData> data, Entity source, Ability ability, Blackboard extraBlackboard, [Optional] Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile)
		{
			return null;
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DABD")]
		[Address(RVA = "0x35F4830", Offset = "0x35F3430", VA = "0x1835F4830")]
		public void AddBuffsToIdList(IList<uint> idList, IList<BuffData> data, Entity source, Ability ability, Blackboard extraBlackboard, [Optional] Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile)
		{
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DABE")]
		[Address(RVA = "0x35F3B10", Offset = "0x35F2710", VA = "0x1835F3B10")]
		public Buff AddBuffById(string key, Entity source, Ability ability, Blackboard extraBlackboard)
		{
			return null;
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x0004FE48 File Offset: 0x0004E048
		[Token(Token = "0x600DABF")]
		[Address(RVA = "0x3600360", Offset = "0x35FEF60", VA = "0x183600360")]
		public bool RemoveBuff(uint instanceUid)
		{
			return default(bool);
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC0")]
		[Address(RVA = "0x3600840", Offset = "0x35FF440", VA = "0x183600840")]
		public void RemoveBuffs(IList<uint> instanceUids)
		{
		}

		// Token: 0x0600DAC1 RID: 56001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC1")]
		[Address(RVA = "0x36005F0", Offset = "0x35FF1F0", VA = "0x1836005F0")]
		public void RemoveBuffs(IList<ObjectPtr<Buff>> buffs)
		{
		}

		// Token: 0x0600DAC2 RID: 56002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC2")]
		[Address(RVA = "0x36004F0", Offset = "0x35FF0F0", VA = "0x1836004F0")]
		public void RemoveBuffs(string buffKey, bool decCntIfStack, bool updateOverrideMap, int decCnt = 1)
		{
		}

		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC3")]
		[Address(RVA = "0x36008F0", Offset = "0x35FF4F0", VA = "0x1836008F0")]
		public void RemoveOneBuffByKey(string buffKey, bool checkBuffFinished = false)
		{
		}

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC4")]
		[Address(RVA = "0x3600410", Offset = "0x35FF010", VA = "0x183600410")]
		public void RemoveBuffsByBuffSource(Entity entity, string buffKey, bool alsoClearNullSource)
		{
		}

		// Token: 0x0600DAC5 RID: 56005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC5")]
		[Address(RVA = "0x3600130", Offset = "0x35FED30", VA = "0x183600130")]
		public void RemoveAllStatusResistableBuffs()
		{
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC6")]
		[Address(RVA = "0x3600080", Offset = "0x35FEC80", VA = "0x183600080")]
		public void RemoveAllBuffsWithCertainAbnormalFlag(AbnormalFlag abnormalFlag)
		{
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAC7")]
		[Address(RVA = "0x35F85B0", Offset = "0x35F71B0", VA = "0x1835F85B0")]
		public void ForceRefreshFinishedBuffs()
		{
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAC8")]
		[Address(RVA = "0x35F8C10", Offset = "0x35F7810", VA = "0x1835F8C10")]
		public Buff GetBuffByUid(uint instanceUid)
		{
			return null;
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x0004FE60 File Offset: 0x0004E060
		[Token(Token = "0x600DAC9")]
		[Address(RVA = "0x35F5FD0", Offset = "0x35F4BD0", VA = "0x1835F5FD0")]
		public bool CheckTriggerableBuffByKeys(string[] buffKeys, [Optional] Buff excludedBuff)
		{
			return default(bool);
		}

		// Token: 0x0600DACA RID: 56010 RVA: 0x0004FE78 File Offset: 0x0004E078
		[Token(Token = "0x600DACA")]
		[Address(RVA = "0x3602C70", Offset = "0x3601870", VA = "0x183602C70")]
		public bool TriggerBuffByKeys(string[] buffKeys, [Optional] Buff excludedBuff, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DACB RID: 56011 RVA: 0x0004FE90 File Offset: 0x0004E090
		[Token(Token = "0x600DACB")]
		[Address(RVA = "0x3602B90", Offset = "0x3601790", VA = "0x183602B90")]
		public bool TriggerAllBuffsByKeys(string[] buffKeys, [Optional] Buff excludedBuff, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DACC RID: 56012 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		[Token(Token = "0x600DACC")]
		[Address(RVA = "0x35F68F0", Offset = "0x35F54F0", VA = "0x1835F68F0")]
		public bool ContainsBuff(string buffKey)
		{
			return default(bool);
		}

		// Token: 0x0600DACD RID: 56013 RVA: 0x0004FEC0 File Offset: 0x0004E0C0
		[Token(Token = "0x600DACD")]
		[Address(RVA = "0x35F6820", Offset = "0x35F5420", VA = "0x1835F6820")]
		public bool ContainsBuffFromCertainSource(string buffKey, Entity source)
		{
			return default(bool);
		}

		// Token: 0x0600DACE RID: 56014 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		[Token(Token = "0x600DACE")]
		[Address(RVA = "0x35F6750", Offset = "0x35F5350", VA = "0x1835F6750")]
		public bool ContainsBuffFromCertainCardUid(string buffKey, uint cardUid)
		{
			return default(bool);
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x0004FEF0 File Offset: 0x0004E0F0
		[Token(Token = "0x600DACF")]
		[Address(RVA = "0x35F6AC0", Offset = "0x35F56C0", VA = "0x1835F6AC0")]
		public bool ContainsStatusResistableBuff()
		{
			return default(bool);
		}

		// Token: 0x0600DAD0 RID: 56016 RVA: 0x0004FF08 File Offset: 0x0004E108
		[Token(Token = "0x600DAD0")]
		[Address(RVA = "0x35F6A30", Offset = "0x35F5630", VA = "0x1835F6A30")]
		public bool ContainsResistableAbnormalFlagsBuff()
		{
			return default(bool);
		}

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x0004FF20 File Offset: 0x0004E120
		[Token(Token = "0x600DAD1")]
		[Address(RVA = "0x35F69A0", Offset = "0x35F55A0", VA = "0x1835F69A0")]
		public bool ContainsIrresistibleAbnormalFlagsBuff()
		{
			return default(bool);
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x0004FF38 File Offset: 0x0004E138
		[Token(Token = "0x600DAD2")]
		[Address(RVA = "0x35F9130", Offset = "0x35F7D30", VA = "0x1835F9130")]
		public int GetBuffStackCount(string buffKey)
		{
			return 0;
		}

		// Token: 0x0600DAD3 RID: 56019 RVA: 0x0004FF50 File Offset: 0x0004E150
		[Token(Token = "0x600DAD3")]
		[Address(RVA = "0x35F9050", Offset = "0x35F7C50", VA = "0x1835F9050")]
		public int GetBuffStackCountFromCertainSource(string buffKey, Entity source)
		{
			return 0;
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x0004FF68 File Offset: 0x0004E168
		[Token(Token = "0x600DAD4")]
		[Address(RVA = "0x35F91F0", Offset = "0x35F7DF0", VA = "0x1835F91F0")]
		public int GetBuffValidStackCountFromCertainSource(string buffKey, Entity source)
		{
			return 0;
		}

		// Token: 0x0600DAD5 RID: 56021 RVA: 0x0004FF80 File Offset: 0x0004E180
		[Token(Token = "0x600DAD5")]
		[Address(RVA = "0x35F8E90", Offset = "0x35F7A90", VA = "0x1835F8E90")]
		public int GetBuffCountByKeyFromAllBuffs(string buffKey)
		{
			return 0;
		}

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x0004FF98 File Offset: 0x0004E198
		[Token(Token = "0x600DAD6")]
		[Address(RVA = "0x35F8DB0", Offset = "0x35F79B0", VA = "0x1835F8DB0")]
		public int GetBuffCountByKeyFromAllBuffsWithCertainSource(string buffKey, Entity source)
		{
			return 0;
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
		[Token(Token = "0x600DAD7")]
		[Address(RVA = "0x35F8CC0", Offset = "0x35F78C0", VA = "0x1835F8CC0")]
		public int GetBuffCountByBlackboardFromAll(string buffKey, string blackboardKey, int blackboardValue)
		{
			return 0;
		}

		// Token: 0x0600DAD8 RID: 56024 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		[Token(Token = "0x600DAD8")]
		[Address(RVA = "0x3603030", Offset = "0x3601C30", VA = "0x183603030")]
		public bool TryGetBuffBlackboardValueByBuffKey(string buffKey, string blackboardKey, bool getMax, out FP result)
		{
			return default(bool);
		}

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		[Token(Token = "0x600DAD9")]
		[Address(RVA = "0x35F92D0", Offset = "0x35F7ED0", VA = "0x1835F92D0")]
		public int GetBuffValidStackCount(string buffKey)
		{
			return 0;
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x0004FFF8 File Offset: 0x0004E1F8
		[Token(Token = "0x600DADA")]
		[Address(RVA = "0x35F9390", Offset = "0x35F7F90", VA = "0x1835F9390")]
		public FP GetBuffValueMultiplierByKeyFromAllBuffs(string buffKey, string blackboardKey, out int cnt, [Optional] Func<FP, FP> getResultFromBlackboardValue)
		{
			return default(FP);
		}

		// Token: 0x0600DADB RID: 56027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DADB")]
		[Address(RVA = "0x36009C0", Offset = "0x35FF5C0", VA = "0x1836009C0")]
		public void ResetAllBuffsTriggerTimer()
		{
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DADC")]
		[Address(RVA = "0x3602950", Offset = "0x3601550", VA = "0x183602950")]
		public void Suicide(bool noSource, bool skipReborn)
		{
		}

		// Token: 0x0600DADD RID: 56029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DADD")]
		[Address(RVA = "0x35F8460", Offset = "0x35F7060", VA = "0x1835F8460")]
		public void FinishWithNoReason()
		{
		}

		// Token: 0x0600DADE RID: 56030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DADE")]
		[Address(RVA = "0x35F8500", Offset = "0x35F7100", VA = "0x1835F8500", Slot = "91")]
		public virtual void FinishWithReachExit(bool switchState = false)
		{
		}

		// Token: 0x0600DADF RID: 56031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DADF")]
		[Address(RVA = "0x3602610", Offset = "0x3601210", VA = "0x183602610")]
		public void ShowDebugLog(string message, [Optional] Color? messageColor, bool log = false)
		{
		}

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAE0")]
		[Address(RVA = "0x36026D0", Offset = "0x36012D0", VA = "0x1836026D0")]
		public void ShowMessage(string message, [Optional] Color? messageColor, bool log = false)
		{
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAE1")]
		[Address(RVA = "0x35F8F50", Offset = "0x35F7B50", VA = "0x1835F8F50")]
		public Effect GetBuffEffect(string effect)
		{
			return null;
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAE2")]
		[Address(RVA = "0x35F9A10", Offset = "0x35F8610", VA = "0x1835F9A10")]
		public void HoldEffect(Effect effect)
		{
		}

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAE3")]
		[Address(RVA = "0x35F9910", Offset = "0x35F8510", VA = "0x1835F9910")]
		public void HoldColorModifier(ColorModifier changer)
		{
		}

		// Token: 0x0600DAE4 RID: 56036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAE4")]
		[Address(RVA = "0x35FFFA0", Offset = "0x35FEBA0", VA = "0x1835FFFA0")]
		public void ReleaseColorModifier(ColorModifier changer)
		{
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00050010 File Offset: 0x0004E210
		[Token(Token = "0x600DAE5")]
		[Address(RVA = "0x35F89E0", Offset = "0x35F75E0", VA = "0x1835F89E0")]
		public Color GetBodyColor()
		{
			return default(Color);
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAE6")]
		[Address(RVA = "0x35F76F0", Offset = "0x35F62F0", VA = "0x1835F76F0")]
		public void EnsureMinSp(FP sp)
		{
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x00050028 File Offset: 0x0004E228
		[Token(Token = "0x600DAE7")]
		[Address(RVA = "0x3602E90", Offset = "0x3601A90", VA = "0x183602E90")]
		public bool TryFindFirstAttachedAbility(string searchName, out Ability result, bool requireActive = false)
		{
			return default(bool);
		}

		// Token: 0x0600DAE8 RID: 56040 RVA: 0x00050040 File Offset: 0x0004E240
		[Token(Token = "0x600DAE8")]
		[Address(RVA = "0x35FAB20", Offset = "0x35F9720", VA = "0x1835FAB20", Slot = "92")]
		public virtual bool IsStayStill()
		{
			return default(bool);
		}

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAE9")]
		[Address(RVA = "0x3602D50", Offset = "0x3601950", VA = "0x183602D50")]
		public Ability TryFindFirstAttachedAbility(string searchName)
		{
			return null;
		}

		// Token: 0x0600DAEA RID: 56042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAEA")]
		public T TryFindFirstAttachedAbility<T>(string searchName) where T : Ability
		{
			return null;
		}

		// Token: 0x0600DAEB RID: 56043 RVA: 0x00050058 File Offset: 0x0004E258
		[Token(Token = "0x600DAEB")]
		[Address(RVA = "0x35F80E0", Offset = "0x35F6CE0", VA = "0x1835F80E0")]
		public int FindAttachedAbilities(string searchName, List<Ability> result)
		{
			return 0;
		}

		// Token: 0x0600DAEC RID: 56044 RVA: 0x00050070 File Offset: 0x0004E270
		[Token(Token = "0x600DAEC")]
		[Address(RVA = "0x35F8700", Offset = "0x35F7300", VA = "0x1835F8700")]
		public int GetAllAttachedAbilities(List<Ability> result)
		{
			return 0;
		}

		// Token: 0x0600DAED RID: 56045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAED")]
		[Address(RVA = "0x35F5940", Offset = "0x35F4540", VA = "0x1835F5940", Slot = "93")]
		public virtual void ChangePathMotionMode(MotionMode mode)
		{
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAEE")]
		[Address(RVA = "0x35F58B0", Offset = "0x35F44B0", VA = "0x1835F58B0", Slot = "94")]
		public virtual void ChangeMotionMode(MotionMode mode)
		{
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAEF")]
		[Address(RVA = "0x3600A50", Offset = "0x35FF650", VA = "0x183600A50", Slot = "95")]
		public virtual void ResetMotionMode()
		{
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAF0")]
		[Address(RVA = "0x3602A70", Offset = "0x3601670", VA = "0x183602A70", Slot = "96")]
		public virtual void SwitchSide(SideType side)
		{
		}

		// Token: 0x0600DAF1 RID: 56049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAF1")]
		[Address(RVA = "0x3601690", Offset = "0x3600290", VA = "0x183601690")]
		public void SetHpDirectly(FP value)
		{
		}

		// Token: 0x0600DAF2 RID: 56050
		[Token(Token = "0x600DAF2")]
		public abstract bool CheckHasFilterTag(string tag);

		// Token: 0x0600DAF3 RID: 56051 RVA: 0x00050088 File Offset: 0x0004E288
		[Token(Token = "0x600DAF3")]
		[Address(RVA = "0x35F5E90", Offset = "0x35F4A90", VA = "0x1835F5E90")]
		public bool CheckOneOfFilterTags(IList<string> tags)
		{
			return default(bool);
		}

		// Token: 0x0600DAF4 RID: 56052 RVA: 0x000500A0 File Offset: 0x0004E2A0
		[Token(Token = "0x600DAF4")]
		[Address(RVA = "0x35F5D00", Offset = "0x35F4900", VA = "0x1835F5D00")]
		public bool CheckOneOfFilterBuffs(IList<string> buffs)
		{
			return default(bool);
		}

		// Token: 0x0600DAF5 RID: 56053 RVA: 0x000500B8 File Offset: 0x0004E2B8
		[Token(Token = "0x600DAF5")]
		[Address(RVA = "0x35F5B50", Offset = "0x35F4750", VA = "0x1835F5B50")]
		public bool CheckOneOfFilterBuffsFromCertainSource(IList<string> buffs, Entity source)
		{
			return default(bool);
		}

		// Token: 0x0600DAF6 RID: 56054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAF6")]
		[Address(RVA = "0x3603820", Offset = "0x3602420", VA = "0x183603820")]
		public void UpdateSpData(SpData spData, bool onlyUpdateSpCost)
		{
		}

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAF7")]
		[Address(RVA = "0x3603760", Offset = "0x3602360", VA = "0x183603760", Slot = "98")]
		protected virtual void UpdateBodyColor()
		{
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DAF8")]
		[Address(RVA = "0x35F8640", Offset = "0x35F7240", VA = "0x1835F8640")]
		public IList<IAbilityAttachment> GetAbilityAttachments(Ability.FamilyGroup group)
		{
			return null;
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAF9")]
		[Address(RVA = "0x35FFCD0", Offset = "0x35FE8D0", VA = "0x1835FFCD0")]
		public void RegisterAbilityAttachment(IAbilityAttachment addition, int mask)
		{
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAFA")]
		[Address(RVA = "0x36034A0", Offset = "0x36020A0", VA = "0x1836034A0")]
		public void UnregisterAbilityAttachment(IAbilityAttachment addition)
		{
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAFB")]
		[Address(RVA = "0x3603610", Offset = "0x3602210", VA = "0x183603610")]
		public void UnregisterAbilityAttachment(IAbilityAttachment addition, int mask)
		{
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAFC")]
		[Address(RVA = "0x3603B80", Offset = "0x3602780", VA = "0x183603B80")]
		private void _ClearAbilityAttachment(IAbilityAttachment addition)
		{
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DAFD")]
		[Address(RVA = "0x3603A70", Offset = "0x3602670", VA = "0x183603A70")]
		private void _ClearAbilityAttachment(IAbilityAttachment addition, int mask)
		{
		}

		// Token: 0x0600DAFE RID: 56062
		[Token(Token = "0x600DAFE")]
		public abstract float PlayAnimation(string animKey, bool forceFromStart = false, float speed = 1f, bool forcePlay = false);

		// Token: 0x0600DAFF RID: 56063
		[Token(Token = "0x600DAFF")]
		public abstract void UpdateAnimPlaybackSpeed(float speed);

		// Token: 0x0600DB00 RID: 56064
		[Token(Token = "0x600DB00")]
		public abstract bool GetAnimationTime(string animKey, out float time);

		// Token: 0x0600DB01 RID: 56065
		[Token(Token = "0x600DB01")]
		public abstract bool GetAnimationTime(string animKey, out float time, out float speed);

		// Token: 0x0600DB02 RID: 56066 RVA: 0x000500D0 File Offset: 0x0004E2D0
		[Token(Token = "0x600DB02")]
		[Address(RVA = "0x36031F0", Offset = "0x3601DF0", VA = "0x1836031F0", Slot = "103")]
		public virtual bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x000500E8 File Offset: 0x0004E2E8
		[Token(Token = "0x600DB03")]
		[Address(RVA = "0x3603380", Offset = "0x3601F80", VA = "0x183603380", Slot = "104")]
		public virtual bool TryIgnoreEffect(string originEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00050100 File Offset: 0x0004E300
		[Token(Token = "0x600DB04")]
		[Address(RVA = "0x3603120", Offset = "0x3601D20", VA = "0x183603120", Slot = "105")]
		public virtual bool TryHookAudio(string signal, string subSingnal, out string newSignal, out string newSubsignal)
		{
			return default(bool);
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00050118 File Offset: 0x0004E318
		[Token(Token = "0x600DB05")]
		[Address(RVA = "0x36032A0", Offset = "0x3601EA0", VA = "0x1836032A0", Slot = "106")]
		public virtual bool TryHookProjectile(string originProjectile, out string graphicProjectileKey, out string logicProjectile, out Entity.MountPointType muzzlePoint)
		{
			return default(bool);
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB06")]
		[Address(RVA = "0x3605320", Offset = "0x3603F20", VA = "0x183605320")]
		protected Entity()
		{
		}

		// Token: 0x0600DB07 RID: 56071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB07")]
		[Address(RVA = "0x35F9C60", Offset = "0x35F8860", VA = "0x1835F9C60")]
		protected void Init(AttributesData attributesData, SideType side, PlayerSide playerSide, MotionMode motionMode, Vector2 pos, float height)
		{
		}

		// Token: 0x0600DB08 RID: 56072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB08")]
		[Address(RVA = "0x35F9DA0", Offset = "0x35F89A0", VA = "0x1835F9DA0")]
		protected void Init(AttributesData attributesData, SideType side, PlayerSide playerSide, MotionMode motionMode, Vector2 pos, float height, SpData spData)
		{
		}

		// Token: 0x0600DB09 RID: 56073 RVA: 0x00050130 File Offset: 0x0004E330
		[Token(Token = "0x600DB09")]
		[Address(RVA = "0x3601A70", Offset = "0x3600670", VA = "0x183601A70", Slot = "107")]
		protected virtual bool SetHpInternal(FP value, bool force, bool noSource, bool skipReborn)
		{
			return default(bool);
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x00050148 File Offset: 0x0004E348
		[Token(Token = "0x600DB0A")]
		[Address(RVA = "0x36018B0", Offset = "0x36004B0", VA = "0x1836018B0")]
		private bool SetHpInternalDirectly(FP value)
		{
			return default(bool);
		}

		// Token: 0x0600DB0B RID: 56075 RVA: 0x00050160 File Offset: 0x0004E360
		[Token(Token = "0x600DB0B")]
		[Address(RVA = "0x36014B0", Offset = "0x36000B0", VA = "0x1836014B0", Slot = "108")]
		protected virtual bool SetEsInternal(FP value)
		{
			return default(bool);
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00050178 File Offset: 0x0004E378
		[Token(Token = "0x600DB0C")]
		[Address(RVA = "0x3602420", Offset = "0x3601020", VA = "0x183602420", Slot = "109")]
		protected virtual bool SetSpInternal(FP value, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00050190 File Offset: 0x0004E390
		[Token(Token = "0x600DB0D")]
		[Address(RVA = "0x3600AE0", Offset = "0x35FF6E0", VA = "0x183600AE0", Slot = "110")]
		protected virtual bool SetAllEpInternal(FP value, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x000501A8 File Offset: 0x0004E3A8
		[Token(Token = "0x600DB0E")]
		[Address(RVA = "0x36011E0", Offset = "0x35FFDE0", VA = "0x1836011E0", Slot = "111")]
		protected virtual bool SetEpInternal(FP value, bool force, ElementType curType)
		{
			return default(bool);
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x000501C0 File Offset: 0x0004E3C0
		[Token(Token = "0x600DB0F")]
		[Address(RVA = "0x35F7300", Offset = "0x35F5F00", VA = "0x1835F7300")]
		protected internal bool DoSetSpInternal(FP value, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600DB10 RID: 56080
		[Token(Token = "0x600DB10")]
		protected abstract StateMachine ConstructStateMachine();

		// Token: 0x0600DB11 RID: 56081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB11")]
		[Address(RVA = "0x35F8290", Offset = "0x35F6E90", VA = "0x1835F8290", Slot = "113")]
		protected virtual void FinishMe(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB12")]
		[Address(RVA = "0x35FFBB0", Offset = "0x35FE7B0", VA = "0x1835FFBB0")]
		public void RecycleSelfImmediately()
		{
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB13")]
		[Address(RVA = "0x35FFC30", Offset = "0x35FE830", VA = "0x1835FFC30")]
		public void RecycleSelfWithDelay()
		{
		}

		// Token: 0x0600DB14 RID: 56084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB14")]
		[Address(RVA = "0x35F3CA0", Offset = "0x35F28A0", VA = "0x1835F3CA0")]
		protected void AddBuffEffect(Buff buff)
		{
		}

		// Token: 0x0600DB15 RID: 56085 RVA: 0x000501D8 File Offset: 0x0004E3D8
		[Token(Token = "0x600DB15")]
		[Address(RVA = "0x3603FB0", Offset = "0x3602BB0", VA = "0x183603FB0")]
		private Vector2 _GetInitDirection(Buff buff)
		{
			return default(Vector2);
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB16")]
		[Address(RVA = "0x36001C0", Offset = "0x35FEDC0", VA = "0x1836001C0")]
		protected void RemoveBuffEffect(string effectKey, bool immediatelyFinishEffect = false)
		{
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB17")]
		[Address(RVA = "0x35F60A0", Offset = "0x35F4CA0", VA = "0x1835F60A0", Slot = "114")]
		protected virtual void ClearAbilities()
		{
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB18")]
		[Address(RVA = "0x35F6290", Offset = "0x35F4E90", VA = "0x1835F6290")]
		protected void ClearHoldEffects()
		{
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB19")]
		[Address(RVA = "0x3603E50", Offset = "0x3602A50", VA = "0x183603E50")]
		private void _EnsureMaxHpNotZero(AttributesData attributesData)
		{
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1A")]
		[Address(RVA = "0x3604DF0", Offset = "0x36039F0", VA = "0x183604DF0")]
		private void _UpdateHpRecovery(FP deltaTime)
		{
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1B")]
		[Address(RVA = "0x3604BC0", Offset = "0x36037C0", VA = "0x183604BC0")]
		private void _UpdateEpRecovery(FP deltaTime)
		{
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1C")]
		[Address(RVA = "0x3604160", Offset = "0x3602D60", VA = "0x183604160")]
		private void _InternalOnly_AttachAbility(Ability ability)
		{
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1D")]
		[Address(RVA = "0x3604220", Offset = "0x3602E20", VA = "0x183604220")]
		private void _InternalOnly_DetachAbility(Ability ability)
		{
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1E")]
		[Address(RVA = "0x35FE8C0", Offset = "0x35FD4C0", VA = "0x1835FE8C0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1F")]
		[Address(RVA = "0x35FCA30", Offset = "0x35FB630", VA = "0x1835FCA30", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB20")]
		[Address(RVA = "0x35FDF90", Offset = "0x35FCB90", VA = "0x1835FDF90", Slot = "115")]
		protected virtual void OnLocate()
		{
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB21")]
		[Address(RVA = "0x35FD560", Offset = "0x35FC160", VA = "0x1835FD560", Slot = "116")]
		protected virtual void OnEsOverZero()
		{
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB22")]
		[Address(RVA = "0x35FDDC0", Offset = "0x35FC9C0", VA = "0x1835FDDC0", Slot = "117")]
		protected virtual void OnHpZero(bool noSource, bool skipReborn)
		{
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB23")]
		[Address(RVA = "0x35FDD30", Offset = "0x35FC930", VA = "0x1835FDD30")]
		protected void OnHpFull()
		{
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB24")]
		[Address(RVA = "0x35FD4C0", Offset = "0x35FC0C0", VA = "0x1835FD4C0", Slot = "118")]
		protected virtual void OnEpZero(ElementType elementType)
		{
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB25")]
		[Address(RVA = "0x35FD870", Offset = "0x35FC470", VA = "0x1835FD870", Slot = "119")]
		protected virtual void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x000501F0 File Offset: 0x0004E3F0
		[Token(Token = "0x600DB26")]
		[Address(RVA = "0x35F59F0", Offset = "0x35F45F0", VA = "0x1835F59F0")]
		public bool CheckCanSwitchToDisappearState()
		{
			return default(bool);
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB27")]
		[Address(RVA = "0x35FC6D0", Offset = "0x35FB2D0", VA = "0x1835FC6D0", Slot = "33")]
		protected override void OnBeforeDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600DB28 RID: 56104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB28")]
		[Address(RVA = "0x35FD3D0", Offset = "0x35FBFD0", VA = "0x1835FD3D0", Slot = "34")]
		protected override void OnDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600DB29 RID: 56105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB29")]
		[Address(RVA = "0x35FDEF0", Offset = "0x35FCAF0", VA = "0x1835FDEF0", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600DB2A RID: 56106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2A")]
		[Address(RVA = "0x35FE810", Offset = "0x35FD410", VA = "0x1835FE810", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600DB2B RID: 56107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2B")]
		[Address(RVA = "0x35FD180", Offset = "0x35FBD80", VA = "0x1835FD180")]
		public void OnCalculateCachedProjectileDamage(Entity target, ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600DB2C RID: 56108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2C")]
		[Address(RVA = "0x35FD250", Offset = "0x35FBE50", VA = "0x1835FD250")]
		public void OnCalculateDamage(Entity target, ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2D")]
		[Address(RVA = "0x35FB2E0", Offset = "0x35F9EE0", VA = "0x1835FB2E0")]
		public void OnAfterCalculateDamage(Entity target, ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2E")]
		[Address(RVA = "0x35FC8D0", Offset = "0x35FB4D0", VA = "0x1835FC8D0")]
		public void OnBeingCalculateDamage(ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB2F")]
		[Address(RVA = "0x35F65E0", Offset = "0x35F51E0", VA = "0x1835F65E0")]
		public static void ClearStaticVariables()
		{
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00050208 File Offset: 0x0004E408
		[Token(Token = "0x600DB30")]
		[Address(RVA = "0x35FAD50", Offset = "0x35F9950", VA = "0x1835FAD50")]
		public bool IsUnhurtableWithModifier(Modifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x00050220 File Offset: 0x0004E420
		[Token(Token = "0x600DB31")]
		[Address(RVA = "0x35F4E90", Offset = "0x35F3A90", VA = "0x1835F4E90")]
		public bool ApplyModifier(ref Modifier modifier, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB32")]
		[Address(RVA = "0x3604750", Offset = "0x3603350", VA = "0x183604750")]
		private void _OnBeforeApplyingModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB33")]
		[Address(RVA = "0x3604460", Offset = "0x3603060", VA = "0x183604460")]
		private void _OnApplyingModifier(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600DB34 RID: 56116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB34")]
		[Address(RVA = "0x35FBB90", Offset = "0x35FA790", VA = "0x1835FBB90")]
		public void OnApplyingSkippedModifer(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB35 RID: 56117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB35")]
		[Address(RVA = "0x35FB5B0", Offset = "0x35FA1B0", VA = "0x1835FB5B0")]
		public void OnAppliedModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB36")]
		[Address(RVA = "0x3604980", Offset = "0x3603580", VA = "0x183604980")]
		private void _OnOutputDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB37")]
		[Address(RVA = "0x35FE4C0", Offset = "0x35FD0C0", VA = "0x1835FE4C0")]
		public void OnOutputModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB38")]
		[Address(RVA = "0x35FC820", Offset = "0x35FB420", VA = "0x1835FC820")]
		public void OnBeforeTargetApplyModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB39")]
		[Address(RVA = "0x35FB3A0", Offset = "0x35F9FA0", VA = "0x1835FB3A0")]
		public void OnAfterOutputDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3A")]
		[Address(RVA = "0x35FB500", Offset = "0x35FA100", VA = "0x1835FB500")]
		public void OnAfterOutputHeal(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB3B RID: 56123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3B")]
		[Address(RVA = "0x35FB450", Offset = "0x35FA050", VA = "0x1835FB450")]
		public void OnAfterOutputElementDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3C")]
		[Address(RVA = "0x35FE740", Offset = "0x35FD340", VA = "0x1835FE740")]
		public void OnProjectileSelectTargets(Projectile projectile, int targetCount)
		{
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3D")]
		[Address(RVA = "0x35FD5F0", Offset = "0x35FC1F0", VA = "0x1835FD5F0")]
		public void OnEvadeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3E")]
		[Address(RVA = "0x35FC980", Offset = "0x35FB580", VA = "0x1835FC980")]
		public void OnBlockDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB3F")]
		[Address(RVA = "0x35FE340", Offset = "0x35FCF40", VA = "0x1835FE340")]
		public void OnOutputAttackOrHeal(Ability ability)
		{
		}

		// Token: 0x0600DB40 RID: 56128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB40")]
		[Address(RVA = "0x35FE290", Offset = "0x35FCE90", VA = "0x1835FE290")]
		public void OnOutputAttackOrHealEachSpell(Ability ability)
		{
		}

		// Token: 0x0600DB41 RID: 56129 RVA: 0x00050238 File Offset: 0x0004E438
		[Token(Token = "0x600DB41")]
		[Address(RVA = "0x35F6B50", Offset = "0x35F5750", VA = "0x1835F6B50", Slot = "120")]
		protected virtual bool DoApplyModifier(ref Modifier modifier, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600DB42 RID: 56130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB42")]
		[Address(RVA = "0x3603C80", Offset = "0x3602880", VA = "0x183603C80")]
		private void _DoApplyEPModifierInternal(ref Modifier modifier, ElementType elementType, bool force)
		{
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB43")]
		[Address(RVA = "0x35FCED0", Offset = "0x35FBAD0", VA = "0x1835FCED0")]
		public void OnBuffStart(Buff buff)
		{
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB44")]
		[Address(RVA = "0x35FCD90", Offset = "0x35FB990", VA = "0x1835FCD90")]
		public void OnBuffShowEffect(Buff buff)
		{
		}

		// Token: 0x0600DB45 RID: 56133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB45")]
		[Address(RVA = "0x35FE1B0", Offset = "0x35FCDB0", VA = "0x1835FE1B0")]
		public void OnOtherBuffStart(Buff otherBuff)
		{
		}

		// Token: 0x0600DB46 RID: 56134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB46")]
		[Address(RVA = "0x35FCC10", Offset = "0x35FB810", VA = "0x1835FCC10")]
		public void OnBuffFinish(Buff buff, bool immediatelyFinishEffect)
		{
		}

		// Token: 0x0600DB47 RID: 56135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB47")]
		[Address(RVA = "0x35FD030", Offset = "0x35FBC30", VA = "0x1835FD030")]
		public void OnBuffTrigger(Buff buff)
		{
		}

		// Token: 0x0600DB48 RID: 56136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB48")]
		[Address(RVA = "0x35FCB10", Offset = "0x35FB710", VA = "0x1835FCB10")]
		public void OnBuffExtend(Buff oldBuff, Buff newBuff)
		{
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB49")]
		[Address(RVA = "0x35FB230", Offset = "0x35F9E30", VA = "0x1835FB230")]
		public void OnAbilityStart(Ability ability)
		{
		}

		// Token: 0x0600DB4A RID: 56138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4A")]
		[Address(RVA = "0x35FB090", Offset = "0x35F9C90", VA = "0x1835FB090", Slot = "121")]
		public virtual void OnAbilityFinish(Ability ability, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600DB4B RID: 56139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4B")]
		[Address(RVA = "0x35FC620", Offset = "0x35FB220", VA = "0x1835FC620")]
		public void OnBeforeAbilitySpellOn(Ability ability)
		{
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4C")]
		[Address(RVA = "0x35FB180", Offset = "0x35F9D80", VA = "0x1835FB180")]
		public void OnAbilitySpellOn(Ability ability)
		{
		}

		// Token: 0x0600DB4D RID: 56141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4D")]
		[Address(RVA = "0x35FAFC0", Offset = "0x35F9BC0", VA = "0x1835FAFC0")]
		public void OnAbilityCastOnTarget(Ability ability, Entity target)
		{
		}

		// Token: 0x0600DB4E RID: 56142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4E")]
		[Address(RVA = "0x35FF650", Offset = "0x35FE250", VA = "0x1835FF650", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DB4F RID: 56143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB4F")]
		[Address(RVA = "0x3604AD0", Offset = "0x36036D0", VA = "0x183604AD0")]
		private void _UpdateCachedAbilities()
		{
		}

		// Token: 0x0600DB50 RID: 56144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB50")]
		[Address(RVA = "0x35FBDF0", Offset = "0x35FA9F0", VA = "0x1835FBDF0", Slot = "122")]
		protected virtual void OnAttributeDirty(AttributeType attributeType, FP oldValue)
		{
		}

		// Token: 0x0600DB51 RID: 56145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB51")]
		[Address(RVA = "0x3604380", Offset = "0x3602F80", VA = "0x183604380")]
		private void _OnAbnormalFlagDirty(AbnormalFlag abnormalFlag)
		{
		}

		// Token: 0x0600DB52 RID: 56146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB52")]
		[Address(RVA = "0x36042E0", Offset = "0x3602EE0", VA = "0x1836042E0")]
		private void _OnAbnormalComboDirty(AbnormalCombo abnormalCombo)
		{
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB53")]
		[Address(RVA = "0x35FD740", Offset = "0x35FC340", VA = "0x1835FD740", Slot = "123")]
		protected virtual void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB54")]
		[Address(RVA = "0x35FE0F0", Offset = "0x35FCCF0", VA = "0x1835FE0F0", Slot = "124")]
		protected virtual void OnMotionModeChanged(MotionMode oldMode, MotionMode newMode)
		{
		}

		// Token: 0x0600DB55 RID: 56149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB55")]
		[Address(RVA = "0x35FD320", Offset = "0x35FBF20", VA = "0x1835FD320", Slot = "125")]
		public virtual void OnDirectionChanged()
		{
		}

		// Token: 0x0600DB56 RID: 56150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB56")]
		[Address(RVA = "0x35FBD20", Offset = "0x35FA920", VA = "0x1835FBD20", Slot = "126")]
		public virtual void OnAttackRangeChanged()
		{
		}

		// Token: 0x0600DB57 RID: 56151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB57")]
		[Address(RVA = "0x35FF5A0", Offset = "0x35FE1A0", VA = "0x1835FF5A0")]
		protected void OnTargetKilled(Entity target)
		{
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x00050250 File Offset: 0x0004E450
		[Token(Token = "0x600DB58")]
		[Address(RVA = "0x3604FF0", Offset = "0x3603BF0", VA = "0x183604FF0")]
		private bool _VerifyAbilityDamageMiss(ref Modifier modifier, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB59")]
		[Address(RVA = "0x35FEE80", Offset = "0x35FDA80", VA = "0x1835FEE80", Slot = "127")]
		protected virtual void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB5A")]
		[Address(RVA = "0x35FF3C0", Offset = "0x35FDFC0", VA = "0x1835FF3C0", Slot = "128")]
		protected virtual void OnTakeHeal(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600DB5B RID: 56155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB5B")]
		[Address(RVA = "0x35FF220", Offset = "0x35FDE20", VA = "0x1835FF220", Slot = "129")]
		protected virtual void OnTakeEPDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB5C")]
		[Address(RVA = "0x35FFA80", Offset = "0x35FE680", VA = "0x1835FFA80", Slot = "130")]
		public virtual void OnTriggerPalsy()
		{
		}

		// Token: 0x0600DB5D RID: 56157 RVA: 0x00050268 File Offset: 0x0004E468
		[Token(Token = "0x600DB5D")]
		[Address(RVA = "0x35F9B50", Offset = "0x35F8750", VA = "0x1835F9B50")]
		public static bool IfReasonIsDeath(Entity.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600DB5E RID: 56158 RVA: 0x00050280 File Offset: 0x0004E480
		[Token(Token = "0x600DB5E")]
		[Address(RVA = "0x35F9BE0", Offset = "0x35F87E0", VA = "0x1835F9BE0")]
		public static bool IfReasonIsHpZero(Entity.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600DB5F RID: 56159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB5F")]
		[Address(RVA = "0x35F7640", Offset = "0x35F6240", VA = "0x1835F7640")]
		protected void EmitEvent(Entity.Event ev)
		{
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB60")]
		[Address(RVA = "0x35F7570", Offset = "0x35F6170", VA = "0x1835F7570")]
		protected void EmitEvent(Entity.Event ev, object arg)
		{
		}

		// Token: 0x0600DB61 RID: 56161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB61")]
		[Address(RVA = "0x35F74A0", Offset = "0x35F60A0", VA = "0x1835F74A0")]
		protected void EmitEvent(Entity.Event ev, params object[] args)
		{
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x00050298 File Offset: 0x0004E498
		[Token(Token = "0x600DB62")]
		[Address(RVA = "0x35F66A0", Offset = "0x35F52A0", VA = "0x1835F66A0", Slot = "35")]
		public int CompareTo(Entity other)
		{
			return 0;
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB63")]
		[Address(RVA = "0x35FFAF0", Offset = "0x35FE6F0", VA = "0x1835FFAF0")]
		public void PlayDialogAnim(Entity.AnimBundle animBundle)
		{
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x000502B0 File Offset: 0x0004E4B0
		[Token(Token = "0x600DB64")]
		[Address(RVA = "0x35FAA00", Offset = "0x35F9600", VA = "0x1835FAA00", Slot = "131")]
		public virtual bool IsInHitRange(Entity.HitRangeOption option)
		{
			return default(bool);
		}

		// Token: 0x0600DB65 RID: 56165 RVA: 0x000502C8 File Offset: 0x0004E4C8
		[Token(Token = "0x600DB65")]
		[Address(RVA = "0x35FAC60", Offset = "0x35F9860", VA = "0x1835FAC60")]
		public bool IsTargetInHitRange(Entity.HitRangeOption option)
		{
			return default(bool);
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB66")]
		[Address(RVA = "0x35FFE40", Offset = "0x35FEA40", VA = "0x1835FFE40")]
		public void RegisterHitRangeProvider(Entity.IHitRangeProvider provider)
		{
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB67")]
		[Address(RVA = "0x36036C0", Offset = "0x36022C0", VA = "0x1836036C0")]
		public void UnregisterHitRangeProvider(string id)
		{
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x000502E0 File Offset: 0x0004E4E0
		[Token(Token = "0x600DB68")]
		[Address(RVA = "0x35F5800", Offset = "0x35F4400", VA = "0x1835F5800", Slot = "132")]
		public virtual bool CanDoAbilitySpellOn(Ability ability, out Ability.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[Token(Token = "0x600DB6B")]
		[Address(RVA = "0x3603430", Offset = "0x3602030", VA = "0x183603430")]
		private Vector2 <>xLuaBaseProxy_get_faceTo()
		{
			return default(Vector2);
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB6C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600DB6D RID: 56173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB6D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600DB6E RID: 56174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB6E")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnBeforeDisappearChanged(bool P0)
		{
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB6F")]
		[Address(RVA = "0x3603410", Offset = "0x3602010", VA = "0x183603410")]
		private void <>xLuaBaseProxy_OnDisappearChanged(bool P0)
		{
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB70")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB71")]
		[Address(RVA = "0x3603420", Offset = "0x3602020", VA = "0x183603420")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB72")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400EB4E RID: 60238
		[Token(Token = "0x400EB4E")]
		private const float FACE_TO_TARGET_MIN_DISTANCE_SQR = 0.040000003f;

		// Token: 0x0400EB4F RID: 60239
		[Token(Token = "0x400EB4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected StateMachine m_stateMachine;

		// Token: 0x0400EB50 RID: 60240
		[Token(Token = "0x400EB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FP m_hp;

		// Token: 0x0400EB51 RID: 60241
		[Token(Token = "0x400EB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FP m_es;

		// Token: 0x0400EB52 RID: 60242
		[Token(Token = "0x400EB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ObscuredFP m_sp;

		// Token: 0x0400EB53 RID: 60243
		[Token(Token = "0x400EB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_respawnCnt;

		// Token: 0x0400EB54 RID: 60244
		[Token(Token = "0x400EB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FP[] m_epArray;

		// Token: 0x0400EB55 RID: 60245
		[Token(Token = "0x400EB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected bool m_isLocated;

		// Token: 0x0400EB56 RID: 60246
		[Token(Token = "0x400EB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool m_startIniting;

		// Token: 0x0400EB57 RID: 60247
		[Token(Token = "0x400EB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool m_isDialogTarget;

		// Token: 0x0400EB58 RID: 60248
		[Token(Token = "0x400EB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector2 m_faceTo;

		// Token: 0x0400EB59 RID: 60249
		[Token(Token = "0x400EB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private MotionMode m_changeableMotionMode;

		// Token: 0x0400EB5A RID: 60250
		[Token(Token = "0x400EB5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Attributes m_attributes;

		// Token: 0x0400EB5B RID: 60251
		[Token(Token = "0x400EB5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private EventPool<Entity.Event> m_eventPool;

		// Token: 0x0400EB5C RID: 60252
		[Token(Token = "0x400EB5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private PrecisePeriodicTimer m_hpRecoverTimer;

		// Token: 0x0400EB5D RID: 60253
		[Token(Token = "0x400EB5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private HashSet<ObjectPtr<Effect>> m_holdEffects;

		// Token: 0x0400EB5E RID: 60254
		[Token(Token = "0x400EB5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<ColorModifier> m_colorModifiers;

		// Token: 0x0400EB5F RID: 60255
		[Token(Token = "0x400EB5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private PrecisePeriodicTimer m_epRecoverTimer;

		// Token: 0x0400EB60 RID: 60256
		[Token(Token = "0x400EB60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected ListSet<Ability> m_abilities;

		// Token: 0x0400EB61 RID: 60257
		[Token(Token = "0x400EB61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected bool m_abilitiesDirtyFlag;

		// Token: 0x0400EB62 RID: 60258
		[Token(Token = "0x400EB62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool m_isSuicide;

		// Token: 0x0400EB63 RID: 60259
		[Token(Token = "0x400EB63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private SharedConsts.Direction m_direction;

		// Token: 0x0400EB64 RID: 60260
		[Token(Token = "0x400EB64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Ability> m_cachedAbilities;

		// Token: 0x0400EB65 RID: 60261
		[Token(Token = "0x400EB65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Entity.SpController m_spController;

		// Token: 0x0400EB66 RID: 60262
		[Token(Token = "0x400EB66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Entity.EPController m_epController;

		// Token: 0x0400EB67 RID: 60263
		[Token(Token = "0x400EB67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Entity.ShieldUIController m_shieldController;

		// Token: 0x0400EB68 RID: 60264
		[Token(Token = "0x400EB68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<string, Entity.BuffEffectHolder> m_buffEffects;

		// Token: 0x0400EB69 RID: 60265
		[Token(Token = "0x400EB69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<IAbilityAttachment>[] m_abilityAttachments;

		// Token: 0x0400EB6A RID: 60266
		[Token(Token = "0x400EB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MountPoint m_footMountPoint;

		// Token: 0x0400EB6B RID: 60267
		[Token(Token = "0x400EB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MountPoint m_hitMountPoint;

		// Token: 0x0400EB6C RID: 60268
		[Token(Token = "0x400EB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private MountPoint m_muzzleMountPoint;

		// Token: 0x0400EB6D RID: 60269
		[Token(Token = "0x400EB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private MountPoint m_headMountPoint;

		// Token: 0x0400EB6E RID: 60270
		[Token(Token = "0x400EB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private MountPoint m_uiMountPoint;

		// Token: 0x0400EB6F RID: 60271
		[Token(Token = "0x400EB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ObjectPtr<Effect>> s_effects;

		// Token: 0x0400EB7B RID: 60283
		[Token(Token = "0x400EB7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Entity.HitRangeManager m_hitRangeManager;

		// Token: 0x0400EB7C RID: 60284
		[Token(Token = "0x400EB7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool s_softLock;

		// Token: 0x0400EB7D RID: 60285
		[Token(Token = "0x400EB7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0400EB7E RID: 60286
		[Token(Token = "0x400EB7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x0400EB7F RID: 60287
		[Token(Token = "0x400EB7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x0400EB80 RID: 60288
		[Token(Token = "0x400EB80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tmplId;

		// Token: 0x0400EB81 RID: 60289
		[Token(Token = "0x400EB81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_realId;

		// Token: 0x0400EB82 RID: 60290
		[Token(Token = "0x400EB82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isMine;

		// Token: 0x0400EB83 RID: 60291
		[Token(Token = "0x400EB83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_alive;

		// Token: 0x0400EB84 RID: 60292
		[Token(Token = "0x400EB84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_aliveOrDying;

		// Token: 0x0400EB85 RID: 60293
		[Token(Token = "0x400EB85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_aliveOrReborn;

		// Token: 0x0400EB86 RID: 60294
		[Token(Token = "0x400EB86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isStateRunning;

		// Token: 0x0400EB87 RID: 60295
		[Token(Token = "0x400EB87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_currentStateId;

		// Token: 0x0400EB88 RID: 60296
		[Token(Token = "0x400EB88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_hpIsFull;

		// Token: 0x0400EB89 RID: 60297
		[Token(Token = "0x400EB89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_epIsFull;

		// Token: 0x0400EB8A RID: 60298
		[Token(Token = "0x400EB8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isInEpBreakRecovery;

		// Token: 0x0400EB8B RID: 60299
		[Token(Token = "0x400EB8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_epRecoveryType;

		// Token: 0x0400EB8C RID: 60300
		[Token(Token = "0x400EB8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_attributes;

		// Token: 0x0400EB8D RID: 60301
		[Token(Token = "0x400EB8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0400EB8E RID: 60302
		[Token(Token = "0x400EB8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_finishReason;

		// Token: 0x0400EB8F RID: 60303
		[Token(Token = "0x400EB8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_finishReason;

		// Token: 0x0400EB90 RID: 60304
		[Token(Token = "0x400EB90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400EB91 RID: 60305
		[Token(Token = "0x400EB91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_faceTo;

		// Token: 0x0400EB92 RID: 60306
		[Token(Token = "0x400EB92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_faceDirection;

		// Token: 0x0400EB93 RID: 60307
		[Token(Token = "0x400EB93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x0400EB94 RID: 60308
		[Token(Token = "0x400EB94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_faceVector;

		// Token: 0x0400EB95 RID: 60309
		[Token(Token = "0x400EB95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_faceToBack;

		// Token: 0x0400EB96 RID: 60310
		[Token(Token = "0x400EB96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_faceToDown;

		// Token: 0x0400EB97 RID: 60311
		[Token(Token = "0x400EB97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_pathMotionMode;

		// Token: 0x0400EB98 RID: 60312
		[Token(Token = "0x400EB98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_pathMotionMode;

		// Token: 0x0400EB99 RID: 60313
		[Token(Token = "0x400EB99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_changeableMotionMode;

		// Token: 0x0400EB9A RID: 60314
		[Token(Token = "0x400EB9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_changeableMotionMode;

		// Token: 0x0400EB9B RID: 60315
		[Token(Token = "0x400EB9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_rawChangeableMotionMode;

		// Token: 0x0400EB9C RID: 60316
		[Token(Token = "0x400EB9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_originTile;

		// Token: 0x0400EB9D RID: 60317
		[Token(Token = "0x400EB9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_originTile;

		// Token: 0x0400EB9E RID: 60318
		[Token(Token = "0x400EB9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_isOnHighland;

		// Token: 0x0400EB9F RID: 60319
		[Token(Token = "0x400EB9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_spController;

		// Token: 0x0400EBA0 RID: 60320
		[Token(Token = "0x400EBA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_epController;

		// Token: 0x0400EBA1 RID: 60321
		[Token(Token = "0x400EBA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_shieldUIController;

		// Token: 0x0400EBA2 RID: 60322
		[Token(Token = "0x400EBA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_unfinished;

		// Token: 0x0400EBA3 RID: 60323
		[Token(Token = "0x400EBA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_isLocated;

		// Token: 0x0400EBA4 RID: 60324
		[Token(Token = "0x400EBA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_respawnCnt;

		// Token: 0x0400EBA5 RID: 60325
		[Token(Token = "0x400EBA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_respawnCnt;

		// Token: 0x0400EBA6 RID: 60326
		[Token(Token = "0x400EBA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_direction;

		// Token: 0x0400EBA7 RID: 60327
		[Token(Token = "0x400EBA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_set_direction;

		// Token: 0x0400EBA8 RID: 60328
		[Token(Token = "0x400EBA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_faceLOrR;

		// Token: 0x0400EBA9 RID: 60329
		[Token(Token = "0x400EBA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_bodyTransform;

		// Token: 0x0400EBAA RID: 60330
		[Token(Token = "0x400EBAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400EBAB RID: 60331
		[Token(Token = "0x400EBAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_graphicFootTransform;

		// Token: 0x0400EBAC RID: 60332
		[Token(Token = "0x400EBAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_directionTransform;

		// Token: 0x0400EBAD RID: 60333
		[Token(Token = "0x400EBAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_stateDebugStr;

		// Token: 0x0400EBAE RID: 60334
		[Token(Token = "0x400EBAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_buffContainer;

		// Token: 0x0400EBAF RID: 60335
		[Token(Token = "0x400EBAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_set_buffContainer;

		// Token: 0x0400EBB0 RID: 60336
		[Token(Token = "0x400EBB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_mapLayer;

		// Token: 0x0400EBB1 RID: 60337
		[Token(Token = "0x400EBB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_set_mapLayer;

		// Token: 0x0400EBB2 RID: 60338
		[Token(Token = "0x400EBB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_isNotAliveAndStartFinishing;

		// Token: 0x0400EBB3 RID: 60339
		[Token(Token = "0x400EBB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_startIniting;

		// Token: 0x0400EBB4 RID: 60340
		[Token(Token = "0x400EBB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_canRecoverHp;

		// Token: 0x0400EBB5 RID: 60341
		[Token(Token = "0x400EBB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_canRecoverSp;

		// Token: 0x0400EBB6 RID: 60342
		[Token(Token = "0x400EBB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_canRecoverEp;

		// Token: 0x0400EBB7 RID: 60343
		[Token(Token = "0x400EBB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_canUseAbility;

		// Token: 0x0400EBB8 RID: 60344
		[Token(Token = "0x400EBB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_canUseAtkOrCbt;

		// Token: 0x0400EBB9 RID: 60345
		[Token(Token = "0x400EBB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_canMove;

		// Token: 0x0400EBBA RID: 60346
		[Token(Token = "0x400EBBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_isSuicide;

		// Token: 0x0400EBBB RID: 60347
		[Token(Token = "0x400EBBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x0400EBBC RID: 60348
		[Token(Token = "0x400EBBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_initState;

		// Token: 0x0400EBBD RID: 60349
		[Token(Token = "0x400EBBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_defaultBodyColor;

		// Token: 0x0400EBBE RID: 60350
		[Token(Token = "0x400EBBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_shouldRenderFlag;

		// Token: 0x0400EBBF RID: 60351
		[Token(Token = "0x400EBBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_set_shouldRenderFlag;

		// Token: 0x0400EBC0 RID: 60352
		[Token(Token = "0x400EBC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_get_graphicBoundRadius;

		// Token: 0x0400EBC1 RID: 60353
		[Token(Token = "0x400EBC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_effectTransform;

		// Token: 0x0400EBC2 RID: 60354
		[Token(Token = "0x400EBC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_get_footMountPoint;

		// Token: 0x0400EBC3 RID: 60355
		[Token(Token = "0x400EBC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_get_hitMountPoint;

		// Token: 0x0400EBC4 RID: 60356
		[Token(Token = "0x400EBC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_get_muzzleMountPoint;

		// Token: 0x0400EBC5 RID: 60357
		[Token(Token = "0x400EBC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_headMountPoint;

		// Token: 0x0400EBC6 RID: 60358
		[Token(Token = "0x400EBC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_get_uiMountPoint;

		// Token: 0x0400EBC7 RID: 60359
		[Token(Token = "0x400EBC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_hp;

		// Token: 0x0400EBC8 RID: 60360
		[Token(Token = "0x400EBC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_set_hp;

		// Token: 0x0400EBC9 RID: 60361
		[Token(Token = "0x400EBC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_es;

		// Token: 0x0400EBCA RID: 60362
		[Token(Token = "0x400EBCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_set_es;

		// Token: 0x0400EBCB RID: 60363
		[Token(Token = "0x400EBCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_hpRatio;

		// Token: 0x0400EBCC RID: 60364
		[Token(Token = "0x400EBCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_sp;

		// Token: 0x0400EBCD RID: 60365
		[Token(Token = "0x400EBCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_set_sp;

		// Token: 0x0400EBCE RID: 60366
		[Token(Token = "0x400EBCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_get_maxSp;

		// Token: 0x0400EBCF RID: 60367
		[Token(Token = "0x400EBCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_set_maxSp;

		// Token: 0x0400EBD0 RID: 60368
		[Token(Token = "0x400EBD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_get_spRatio;

		// Token: 0x0400EBD1 RID: 60369
		[Token(Token = "0x400EBD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_get_minusHp;

		// Token: 0x0400EBD2 RID: 60370
		[Token(Token = "0x400EBD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_set_minusHp;

		// Token: 0x0400EBD3 RID: 60371
		[Token(Token = "0x400EBD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_get_maxMinusHpRatio;

		// Token: 0x0400EBD4 RID: 60372
		[Token(Token = "0x400EBD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_set_maxMinusHpRatio;

		// Token: 0x0400EBD5 RID: 60373
		[Token(Token = "0x400EBD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_get_maxMinusHp;

		// Token: 0x0400EBD6 RID: 60374
		[Token(Token = "0x400EBD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_get_epArray;

		// Token: 0x0400EBD7 RID: 60375
		[Token(Token = "0x400EBD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_minEpType;

		// Token: 0x0400EBD8 RID: 60376
		[Token(Token = "0x400EBD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_get_minEpRatio;

		// Token: 0x0400EBD9 RID: 60377
		[Token(Token = "0x400EBD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_get_maxEp;

		// Token: 0x0400EBDA RID: 60378
		[Token(Token = "0x400EBDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_get_attackTime;

		// Token: 0x0400EBDB RID: 60379
		[Token(Token = "0x400EBDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_get_maxHp;

		// Token: 0x0400EBDC RID: 60380
		[Token(Token = "0x400EBDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_get_maxEs;

		// Token: 0x0400EBDD RID: 60381
		[Token(Token = "0x400EBDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_get_esToShow;

		// Token: 0x0400EBDE RID: 60382
		[Token(Token = "0x400EBDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_get_esRatioToShow;

		// Token: 0x0400EBDF RID: 60383
		[Token(Token = "0x400EBDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_get_atk;

		// Token: 0x0400EBE0 RID: 60384
		[Token(Token = "0x400EBE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_get_def;

		// Token: 0x0400EBE1 RID: 60385
		[Token(Token = "0x400EBE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_get_magicResistance;

		// Token: 0x0400EBE2 RID: 60386
		[Token(Token = "0x400EBE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_get_epDamageResistance;

		// Token: 0x0400EBE3 RID: 60387
		[Token(Token = "0x400EBE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_get_epResistance;

		// Token: 0x0400EBE4 RID: 60388
		[Token(Token = "0x400EBE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_get_damageHitratePhysical;

		// Token: 0x0400EBE5 RID: 60389
		[Token(Token = "0x400EBE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_get_damageHitrateMagical;

		// Token: 0x0400EBE6 RID: 60390
		[Token(Token = "0x400EBE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x0400EBE7 RID: 60391
		[Token(Token = "0x400EBE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_get_blockCnt;

		// Token: 0x0400EBE8 RID: 60392
		[Token(Token = "0x400EBE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_get_moveSpeed;

		// Token: 0x0400EBE9 RID: 60393
		[Token(Token = "0x400EBE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_get_attackSpeed;

		// Token: 0x0400EBEA RID: 60394
		[Token(Token = "0x400EBEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_get_baseAttackTime;

		// Token: 0x0400EBEB RID: 60395
		[Token(Token = "0x400EBEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_get_defPenetrateRatio;

		// Token: 0x0400EBEC RID: 60396
		[Token(Token = "0x400EBEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_get_defPenetrateFixed;

		// Token: 0x0400EBED RID: 60397
		[Token(Token = "0x400EBED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_get_magicResistPenetrate;

		// Token: 0x0400EBEE RID: 60398
		[Token(Token = "0x400EBEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_get_magicResistPenetrateFixed;

		// Token: 0x0400EBEF RID: 60399
		[Token(Token = "0x400EBEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_get_oneMinusStatusResistance;

		// Token: 0x0400EBF0 RID: 60400
		[Token(Token = "0x400EBF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_get_sumUpHpRecoveryPerSec;

		// Token: 0x0400EBF1 RID: 60401
		[Token(Token = "0x400EBF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_get_spRecoveryPerSec;

		// Token: 0x0400EBF2 RID: 60402
		[Token(Token = "0x400EBF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_get_sumUpEpRecoveryPerSec;

		// Token: 0x0400EBF3 RID: 60403
		[Token(Token = "0x400EBF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_get_abilityRangeForwardExtend;

		// Token: 0x0400EBF4 RID: 60404
		[Token(Token = "0x400EBF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_get_tauntLevel;

		// Token: 0x0400EBF5 RID: 60405
		[Token(Token = "0x400EBF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_get_baseForceLevel;

		// Token: 0x0400EBF6 RID: 60406
		[Token(Token = "0x400EBF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_get_massLevel;

		// Token: 0x0400EBF7 RID: 60407
		[Token(Token = "0x400EBF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_get_epBreakRecoverSpeed;

		// Token: 0x0400EBF8 RID: 60408
		[Token(Token = "0x400EBF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_get_isStunned;

		// Token: 0x0400EBF9 RID: 60409
		[Token(Token = "0x400EBF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_get_isCold;

		// Token: 0x0400EBFA RID: 60410
		[Token(Token = "0x400EBFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_get_isFrozen;

		// Token: 0x0400EBFB RID: 60411
		[Token(Token = "0x400EBFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_get_isDoze;

		// Token: 0x0400EBFC RID: 60412
		[Token(Token = "0x400EBFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_get_isLevitate;

		// Token: 0x0400EBFD RID: 60413
		[Token(Token = "0x400EBFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_get_isUnmovable;

		// Token: 0x0400EBFE RID: 60414
		[Token(Token = "0x400EBFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_get_isSleeping;

		// Token: 0x0400EBFF RID: 60415
		[Token(Token = "0x400EBFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_get_spRecoverStopped;

		// Token: 0x0400EC00 RID: 60416
		[Token(Token = "0x400EC00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_get_spModifyStopped;

		// Token: 0x0400EC01 RID: 60417
		[Token(Token = "0x400EC01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_get_isMotionTargetFree;

		// Token: 0x0400EC02 RID: 60418
		[Token(Token = "0x400EC02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_get_spRecoverRatio;

		// Token: 0x0400EC03 RID: 60419
		[Token(Token = "0x400EC03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_get_isTargetFree;

		// Token: 0x0400EC04 RID: 60420
		[Token(Token = "0x400EC04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_get_isFeared;

		// Token: 0x0400EC05 RID: 60421
		[Token(Token = "0x400EC05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_get_isPalsy;

		// Token: 0x0400EC06 RID: 60422
		[Token(Token = "0x400EC06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_get_isPalsying;

		// Token: 0x0400EC07 RID: 60423
		[Token(Token = "0x400EC07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_get_isAttracted;

		// Token: 0x0400EC08 RID: 60424
		[Token(Token = "0x400EC08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_IsStillTargetFreeWithImmuneFlag;

		// Token: 0x0400EC09 RID: 60425
		[Token(Token = "0x400EC09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_isTargetFreeWithImmuneFlag;

		// Token: 0x0400EC0A RID: 60426
		[Token(Token = "0x400EC0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_isStillMotionTargetFreeWithImmuneFlag;

		// Token: 0x0400EC0B RID: 60427
		[Token(Token = "0x400EC0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_isMotionTargetFreeWithImmuneFlag;

		// Token: 0x0400EC0C RID: 60428
		[Token(Token = "0x400EC0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_get_isBlockFree;

		// Token: 0x0400EC0D RID: 60429
		[Token(Token = "0x400EC0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0400EC0E RID: 60430
		[Token(Token = "0x400EC0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_get_isHiddenToAlly;

		// Token: 0x0400EC0F RID: 60431
		[Token(Token = "0x400EC0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_get_isInvincible;

		// Token: 0x0400EC10 RID: 60432
		[Token(Token = "0x400EC10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_get_isUndeadable;

		// Token: 0x0400EC11 RID: 60433
		[Token(Token = "0x400EC11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_get_isHealFree;

		// Token: 0x0400EC12 RID: 60434
		[Token(Token = "0x400EC12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_get_isAllyTargetFree;

		// Token: 0x0400EC13 RID: 60435
		[Token(Token = "0x400EC13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0_get_isEPFreeAll;

		// Token: 0x0400EC14 RID: 60436
		[Token(Token = "0x400EC14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_get_isUnbalanceImmune;

		// Token: 0x0400EC15 RID: 60437
		[Token(Token = "0x400EC15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_get_isDisarmed;

		// Token: 0x0400EC16 RID: 60438
		[Token(Token = "0x400EC16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_get_isSilenced;

		// Token: 0x0400EC17 RID: 60439
		[Token(Token = "0x400EC17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_get_isSkillActivatable;

		// Token: 0x0400EC18 RID: 60440
		[Token(Token = "0x400EC18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0_get_isSkillActivatableInAbnormal;

		// Token: 0x0400EC19 RID: 60441
		[Token(Token = "0x400EC19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_get_isSilencedOrStunned;

		// Token: 0x0400EC1A RID: 60442
		[Token(Token = "0x400EC1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0_get_inAbnormalState;

		// Token: 0x0400EC1B RID: 60443
		[Token(Token = "0x400EC1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_get_inAbnormalStateButNotDoze;

		// Token: 0x0400EC1C RID: 60444
		[Token(Token = "0x400EC1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_get_isCamouflage;

		// Token: 0x0400EC1D RID: 60445
		[Token(Token = "0x400EC1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_get_maxDeployCnt;

		// Token: 0x0400EC1E RID: 60446
		[Token(Token = "0x400EC1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_get_maxDeployStackCnt;

		// Token: 0x0400EC1F RID: 60447
		[Token(Token = "0x400EC1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_get_isDialogTarget;

		// Token: 0x0400EC20 RID: 60448
		[Token(Token = "0x400EC20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0_set_isDialogTarget;

		// Token: 0x0400EC21 RID: 60449
		[Token(Token = "0x400EC21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_FaceToDirection;

		// Token: 0x0400EC22 RID: 60450
		[Token(Token = "0x400EC22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_FaceToFront;

		// Token: 0x0400EC23 RID: 60451
		[Token(Token = "0x400EC23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_FaceToBack;

		// Token: 0x0400EC24 RID: 60452
		[Token(Token = "0x400EC24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix0_FaceTo;

		// Token: 0x0400EC25 RID: 60453
		[Token(Token = "0x400EC25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0_FaceToTarget;

		// Token: 0x0400EC26 RID: 60454
		[Token(Token = "0x400EC26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_SetBodyDirection;

		// Token: 0x0400EC27 RID: 60455
		[Token(Token = "0x400EC27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix1_SetBodyDirection;

		// Token: 0x0400EC28 RID: 60456
		[Token(Token = "0x400EC28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix0_SetBodyAndFaceDirection;

		// Token: 0x0400EC29 RID: 60457
		[Token(Token = "0x400EC29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_GetEffectReplacePairs;

		// Token: 0x0400EC2A RID: 60458
		[Token(Token = "0x400EC2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400EC2B RID: 60459
		[Token(Token = "0x400EC2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_GetMountPointForEffect;

		// Token: 0x0400EC2C RID: 60460
		[Token(Token = "0x400EC2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_AddBuff;

		// Token: 0x0400EC2D RID: 60461
		[Token(Token = "0x400EC2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix1_AddBuff;

		// Token: 0x0400EC2E RID: 60462
		[Token(Token = "0x400EC2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0_AddBuffs;

		// Token: 0x0400EC2F RID: 60463
		[Token(Token = "0x400EC2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0_AddBuffsToIdList;

		// Token: 0x0400EC30 RID: 60464
		[Token(Token = "0x400EC30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix0_AddBuffById;

		// Token: 0x0400EC31 RID: 60465
		[Token(Token = "0x400EC31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_RemoveBuff;

		// Token: 0x0400EC32 RID: 60466
		[Token(Token = "0x400EC32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0_RemoveBuffs;

		// Token: 0x0400EC33 RID: 60467
		[Token(Token = "0x400EC33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix1_RemoveBuffs;

		// Token: 0x0400EC34 RID: 60468
		[Token(Token = "0x400EC34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix2_RemoveBuffs;

		// Token: 0x0400EC35 RID: 60469
		[Token(Token = "0x400EC35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0_RemoveOneBuffByKey;

		// Token: 0x0400EC36 RID: 60470
		[Token(Token = "0x400EC36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0_RemoveBuffsByBuffSource;

		// Token: 0x0400EC37 RID: 60471
		[Token(Token = "0x400EC37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0_RemoveAllStatusResistableBuffs;

		// Token: 0x0400EC38 RID: 60472
		[Token(Token = "0x400EC38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_RemoveAllBuffsWithCertainAbnormalFlag;

		// Token: 0x0400EC39 RID: 60473
		[Token(Token = "0x400EC39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0_ForceRefreshFinishedBuffs;

		// Token: 0x0400EC3A RID: 60474
		[Token(Token = "0x400EC3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0_GetBuffByUid;

		// Token: 0x0400EC3B RID: 60475
		[Token(Token = "0x400EC3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0_CheckTriggerableBuffByKeys;

		// Token: 0x0400EC3C RID: 60476
		[Token(Token = "0x400EC3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0_TriggerBuffByKeys;

		// Token: 0x0400EC3D RID: 60477
		[Token(Token = "0x400EC3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0_TriggerAllBuffsByKeys;

		// Token: 0x0400EC3E RID: 60478
		[Token(Token = "0x400EC3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0_ContainsBuff;

		// Token: 0x0400EC3F RID: 60479
		[Token(Token = "0x400EC3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix0_ContainsBuffFromCertainSource;

		// Token: 0x0400EC40 RID: 60480
		[Token(Token = "0x400EC40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0_ContainsBuffFromCertainCardUid;

		// Token: 0x0400EC41 RID: 60481
		[Token(Token = "0x400EC41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private static DelegateBridge __Hotfix0_ContainsStatusResistableBuff;

		// Token: 0x0400EC42 RID: 60482
		[Token(Token = "0x400EC42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		private static DelegateBridge __Hotfix0_ContainsResistableAbnormalFlagsBuff;

		// Token: 0x0400EC43 RID: 60483
		[Token(Token = "0x400EC43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		private static DelegateBridge __Hotfix0_ContainsIrresistibleAbnormalFlagsBuff;

		// Token: 0x0400EC44 RID: 60484
		[Token(Token = "0x400EC44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		private static DelegateBridge __Hotfix0_GetBuffStackCount;

		// Token: 0x0400EC45 RID: 60485
		[Token(Token = "0x400EC45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		private static DelegateBridge __Hotfix0_GetBuffStackCountFromCertainSource;

		// Token: 0x0400EC46 RID: 60486
		[Token(Token = "0x400EC46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		private static DelegateBridge __Hotfix0_GetBuffValidStackCountFromCertainSource;

		// Token: 0x0400EC47 RID: 60487
		[Token(Token = "0x400EC47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static DelegateBridge __Hotfix0_GetBuffCountByKeyFromAllBuffs;

		// Token: 0x0400EC48 RID: 60488
		[Token(Token = "0x400EC48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		private static DelegateBridge __Hotfix0_GetBuffCountByKeyFromAllBuffsWithCertainSource;

		// Token: 0x0400EC49 RID: 60489
		[Token(Token = "0x400EC49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		private static DelegateBridge __Hotfix0_GetBuffCountByBlackboardFromAll;

		// Token: 0x0400EC4A RID: 60490
		[Token(Token = "0x400EC4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private static DelegateBridge __Hotfix0_TryGetBuffBlackboardValueByBuffKey;

		// Token: 0x0400EC4B RID: 60491
		[Token(Token = "0x400EC4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		private static DelegateBridge __Hotfix0_GetBuffValidStackCount;

		// Token: 0x0400EC4C RID: 60492
		[Token(Token = "0x400EC4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		private static DelegateBridge __Hotfix0_GetBuffValueMultiplierByKeyFromAllBuffs;

		// Token: 0x0400EC4D RID: 60493
		[Token(Token = "0x400EC4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		private static DelegateBridge __Hotfix0_ResetAllBuffsTriggerTimer;

		// Token: 0x0400EC4E RID: 60494
		[Token(Token = "0x400EC4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		private static DelegateBridge __Hotfix0_Suicide;

		// Token: 0x0400EC4F RID: 60495
		[Token(Token = "0x400EC4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private static DelegateBridge __Hotfix0_FinishWithNoReason;

		// Token: 0x0400EC50 RID: 60496
		[Token(Token = "0x400EC50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		private static DelegateBridge __Hotfix0_FinishWithReachExit;

		// Token: 0x0400EC51 RID: 60497
		[Token(Token = "0x400EC51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		private static DelegateBridge __Hotfix0_ShowDebugLog;

		// Token: 0x0400EC52 RID: 60498
		[Token(Token = "0x400EC52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private static DelegateBridge __Hotfix0_ShowMessage;

		// Token: 0x0400EC53 RID: 60499
		[Token(Token = "0x400EC53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private static DelegateBridge __Hotfix0_GetBuffEffect;

		// Token: 0x0400EC54 RID: 60500
		[Token(Token = "0x400EC54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		private static DelegateBridge __Hotfix0_HoldEffect;

		// Token: 0x0400EC55 RID: 60501
		[Token(Token = "0x400EC55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private static DelegateBridge __Hotfix0_HoldColorModifier;

		// Token: 0x0400EC56 RID: 60502
		[Token(Token = "0x400EC56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		private static DelegateBridge __Hotfix0_ReleaseColorModifier;

		// Token: 0x0400EC57 RID: 60503
		[Token(Token = "0x400EC57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private static DelegateBridge __Hotfix0_GetBodyColor;

		// Token: 0x0400EC58 RID: 60504
		[Token(Token = "0x400EC58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private static DelegateBridge __Hotfix0_EnsureMinSp;

		// Token: 0x0400EC59 RID: 60505
		[Token(Token = "0x400EC59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private static DelegateBridge __Hotfix0_TryFindFirstAttachedAbility;

		// Token: 0x0400EC5A RID: 60506
		[Token(Token = "0x400EC5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		private static DelegateBridge __Hotfix0_IsStayStill;

		// Token: 0x0400EC5B RID: 60507
		[Token(Token = "0x400EC5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		private static DelegateBridge __Hotfix1_TryFindFirstAttachedAbility;

		// Token: 0x0400EC5C RID: 60508
		[Token(Token = "0x400EC5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		private static DelegateBridge __Hotfix2_TryFindFirstAttachedAbility;

		// Token: 0x0400EC5D RID: 60509
		[Token(Token = "0x400EC5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		private static DelegateBridge __Hotfix0_FindAttachedAbilities;

		// Token: 0x0400EC5E RID: 60510
		[Token(Token = "0x400EC5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private static DelegateBridge __Hotfix0_GetAllAttachedAbilities;

		// Token: 0x0400EC5F RID: 60511
		[Token(Token = "0x400EC5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		private static DelegateBridge __Hotfix0_ChangePathMotionMode;

		// Token: 0x0400EC60 RID: 60512
		[Token(Token = "0x400EC60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		private static DelegateBridge __Hotfix0_ChangeMotionMode;

		// Token: 0x0400EC61 RID: 60513
		[Token(Token = "0x400EC61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private static DelegateBridge __Hotfix0_ResetMotionMode;

		// Token: 0x0400EC62 RID: 60514
		[Token(Token = "0x400EC62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private static DelegateBridge __Hotfix0_SwitchSide;

		// Token: 0x0400EC63 RID: 60515
		[Token(Token = "0x400EC63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private static DelegateBridge __Hotfix0_SetHpDirectly;

		// Token: 0x0400EC64 RID: 60516
		[Token(Token = "0x400EC64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private static DelegateBridge __Hotfix0_CheckOneOfFilterTags;

		// Token: 0x0400EC65 RID: 60517
		[Token(Token = "0x400EC65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private static DelegateBridge __Hotfix0_CheckOneOfFilterBuffs;

		// Token: 0x0400EC66 RID: 60518
		[Token(Token = "0x400EC66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private static DelegateBridge __Hotfix0_CheckOneOfFilterBuffsFromCertainSource;

		// Token: 0x0400EC67 RID: 60519
		[Token(Token = "0x400EC67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private static DelegateBridge __Hotfix0_UpdateSpData;

		// Token: 0x0400EC68 RID: 60520
		[Token(Token = "0x400EC68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private static DelegateBridge __Hotfix0_UpdateBodyColor;

		// Token: 0x0400EC69 RID: 60521
		[Token(Token = "0x400EC69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private static DelegateBridge __Hotfix0_GetAbilityAttachments;

		// Token: 0x0400EC6A RID: 60522
		[Token(Token = "0x400EC6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private static DelegateBridge __Hotfix0_RegisterAbilityAttachment;

		// Token: 0x0400EC6B RID: 60523
		[Token(Token = "0x400EC6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		private static DelegateBridge __Hotfix0_UnregisterAbilityAttachment;

		// Token: 0x0400EC6C RID: 60524
		[Token(Token = "0x400EC6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private static DelegateBridge __Hotfix1_UnregisterAbilityAttachment;

		// Token: 0x0400EC6D RID: 60525
		[Token(Token = "0x400EC6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private static DelegateBridge __Hotfix0__ClearAbilityAttachment;

		// Token: 0x0400EC6E RID: 60526
		[Token(Token = "0x400EC6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		private static DelegateBridge __Hotfix1__ClearAbilityAttachment;

		// Token: 0x0400EC6F RID: 60527
		[Token(Token = "0x400EC6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400EC70 RID: 60528
		[Token(Token = "0x400EC70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		private static DelegateBridge __Hotfix0_TryIgnoreEffect;

		// Token: 0x0400EC71 RID: 60529
		[Token(Token = "0x400EC71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x0400EC72 RID: 60530
		[Token(Token = "0x400EC72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		private static DelegateBridge __Hotfix0_TryHookProjectile;

		// Token: 0x0400EC73 RID: 60531
		[Token(Token = "0x400EC73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400EC74 RID: 60532
		[Token(Token = "0x400EC74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EC75 RID: 60533
		[Token(Token = "0x400EC75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x0400EC76 RID: 60534
		[Token(Token = "0x400EC76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		private static DelegateBridge __Hotfix0_SetHpInternal;

		// Token: 0x0400EC77 RID: 60535
		[Token(Token = "0x400EC77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		private static DelegateBridge __Hotfix0_SetHpInternalDirectly;

		// Token: 0x0400EC78 RID: 60536
		[Token(Token = "0x400EC78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		private static DelegateBridge __Hotfix0_SetEsInternal;

		// Token: 0x0400EC79 RID: 60537
		[Token(Token = "0x400EC79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private static DelegateBridge __Hotfix0_SetSpInternal;

		// Token: 0x0400EC7A RID: 60538
		[Token(Token = "0x400EC7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private static DelegateBridge __Hotfix0_SetAllEpInternal;

		// Token: 0x0400EC7B RID: 60539
		[Token(Token = "0x400EC7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private static DelegateBridge __Hotfix0_SetEpInternal;

		// Token: 0x0400EC7C RID: 60540
		[Token(Token = "0x400EC7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		private static DelegateBridge __Hotfix0_DoSetSpInternal;

		// Token: 0x0400EC7D RID: 60541
		[Token(Token = "0x400EC7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private static DelegateBridge __Hotfix0_FinishMe;

		// Token: 0x0400EC7E RID: 60542
		[Token(Token = "0x400EC7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private static DelegateBridge __Hotfix0_RecycleSelfImmediately;

		// Token: 0x0400EC7F RID: 60543
		[Token(Token = "0x400EC7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		private static DelegateBridge __Hotfix0_RecycleSelfWithDelay;

		// Token: 0x0400EC80 RID: 60544
		[Token(Token = "0x400EC80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		private static DelegateBridge __Hotfix0_AddBuffEffect;

		// Token: 0x0400EC81 RID: 60545
		[Token(Token = "0x400EC81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		private static DelegateBridge __Hotfix0__GetInitDirection;

		// Token: 0x0400EC82 RID: 60546
		[Token(Token = "0x400EC82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		private static DelegateBridge __Hotfix0_RemoveBuffEffect;

		// Token: 0x0400EC83 RID: 60547
		[Token(Token = "0x400EC83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		private static DelegateBridge __Hotfix0_ClearAbilities;

		// Token: 0x0400EC84 RID: 60548
		[Token(Token = "0x400EC84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		private static DelegateBridge __Hotfix0_ClearHoldEffects;

		// Token: 0x0400EC85 RID: 60549
		[Token(Token = "0x400EC85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		private static DelegateBridge __Hotfix0__EnsureMaxHpNotZero;

		// Token: 0x0400EC86 RID: 60550
		[Token(Token = "0x400EC86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		private static DelegateBridge __Hotfix0__UpdateHpRecovery;

		// Token: 0x0400EC87 RID: 60551
		[Token(Token = "0x400EC87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		private static DelegateBridge __Hotfix0__UpdateEpRecovery;

		// Token: 0x0400EC88 RID: 60552
		[Token(Token = "0x400EC88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		private static DelegateBridge __Hotfix0__InternalOnly_AttachAbility;

		// Token: 0x0400EC89 RID: 60553
		[Token(Token = "0x400EC89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		private static DelegateBridge __Hotfix0__InternalOnly_DetachAbility;

		// Token: 0x0400EC8A RID: 60554
		[Token(Token = "0x400EC8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400EC8B RID: 60555
		[Token(Token = "0x400EC8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x0400EC8C RID: 60556
		[Token(Token = "0x400EC8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		private static DelegateBridge __Hotfix0_OnLocate;

		// Token: 0x0400EC8D RID: 60557
		[Token(Token = "0x400EC8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		private static DelegateBridge __Hotfix0_OnEsOverZero;

		// Token: 0x0400EC8E RID: 60558
		[Token(Token = "0x400EC8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		private static DelegateBridge __Hotfix0_OnHpZero;

		// Token: 0x0400EC8F RID: 60559
		[Token(Token = "0x400EC8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		private static DelegateBridge __Hotfix0_OnHpFull;

		// Token: 0x0400EC90 RID: 60560
		[Token(Token = "0x400EC90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		private static DelegateBridge __Hotfix0_OnEpZero;

		// Token: 0x0400EC91 RID: 60561
		[Token(Token = "0x400EC91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400EC92 RID: 60562
		[Token(Token = "0x400EC92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		private static DelegateBridge __Hotfix0_CheckCanSwitchToDisappearState;

		// Token: 0x0400EC93 RID: 60563
		[Token(Token = "0x400EC93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		private static DelegateBridge __Hotfix0_OnBeforeDisappearChanged;

		// Token: 0x0400EC94 RID: 60564
		[Token(Token = "0x400EC94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		private static DelegateBridge __Hotfix0_OnDisappearChanged;

		// Token: 0x0400EC95 RID: 60565
		[Token(Token = "0x400EC95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EC96 RID: 60566
		[Token(Token = "0x400EC96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400EC97 RID: 60567
		[Token(Token = "0x400EC97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		private static DelegateBridge __Hotfix0_OnCalculateCachedProjectileDamage;

		// Token: 0x0400EC98 RID: 60568
		[Token(Token = "0x400EC98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
		private static DelegateBridge __Hotfix0_OnCalculateDamage;

		// Token: 0x0400EC99 RID: 60569
		[Token(Token = "0x400EC99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		private static DelegateBridge __Hotfix0_OnAfterCalculateDamage;

		// Token: 0x0400EC9A RID: 60570
		[Token(Token = "0x400EC9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		private static DelegateBridge __Hotfix0_OnBeingCalculateDamage;

		// Token: 0x0400EC9B RID: 60571
		[Token(Token = "0x400EC9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		private static DelegateBridge __Hotfix0_ClearStaticVariables;

		// Token: 0x0400EC9C RID: 60572
		[Token(Token = "0x400EC9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x908")]
		private static DelegateBridge __Hotfix0_IsUnhurtableWithModifier;

		// Token: 0x0400EC9D RID: 60573
		[Token(Token = "0x400EC9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x910")]
		private static DelegateBridge __Hotfix0_ApplyModifier;

		// Token: 0x0400EC9E RID: 60574
		[Token(Token = "0x400EC9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x918")]
		private static DelegateBridge __Hotfix0__OnBeforeApplyingModifier;

		// Token: 0x0400EC9F RID: 60575
		[Token(Token = "0x400EC9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		private static DelegateBridge __Hotfix0__OnApplyingModifier;

		// Token: 0x0400ECA0 RID: 60576
		[Token(Token = "0x400ECA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x928")]
		private static DelegateBridge __Hotfix0_OnApplyingSkippedModifer;

		// Token: 0x0400ECA1 RID: 60577
		[Token(Token = "0x400ECA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		private static DelegateBridge __Hotfix0_OnAppliedModifier;

		// Token: 0x0400ECA2 RID: 60578
		[Token(Token = "0x400ECA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x938")]
		private static DelegateBridge __Hotfix0__OnOutputDamage;

		// Token: 0x0400ECA3 RID: 60579
		[Token(Token = "0x400ECA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		private static DelegateBridge __Hotfix0_OnOutputModifier;

		// Token: 0x0400ECA4 RID: 60580
		[Token(Token = "0x400ECA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x948")]
		private static DelegateBridge __Hotfix0_OnBeforeTargetApplyModifier;

		// Token: 0x0400ECA5 RID: 60581
		[Token(Token = "0x400ECA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		private static DelegateBridge __Hotfix0_OnAfterOutputDamage;

		// Token: 0x0400ECA6 RID: 60582
		[Token(Token = "0x400ECA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x958")]
		private static DelegateBridge __Hotfix0_OnAfterOutputHeal;

		// Token: 0x0400ECA7 RID: 60583
		[Token(Token = "0x400ECA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x960")]
		private static DelegateBridge __Hotfix0_OnAfterOutputElementDamage;

		// Token: 0x0400ECA8 RID: 60584
		[Token(Token = "0x400ECA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x968")]
		private static DelegateBridge __Hotfix0_OnProjectileSelectTargets;

		// Token: 0x0400ECA9 RID: 60585
		[Token(Token = "0x400ECA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		private static DelegateBridge __Hotfix0_OnEvadeDamage;

		// Token: 0x0400ECAA RID: 60586
		[Token(Token = "0x400ECAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x978")]
		private static DelegateBridge __Hotfix0_OnBlockDamage;

		// Token: 0x0400ECAB RID: 60587
		[Token(Token = "0x400ECAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		private static DelegateBridge __Hotfix0_OnOutputAttackOrHeal;

		// Token: 0x0400ECAC RID: 60588
		[Token(Token = "0x400ECAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x988")]
		private static DelegateBridge __Hotfix0_OnOutputAttackOrHealEachSpell;

		// Token: 0x0400ECAD RID: 60589
		[Token(Token = "0x400ECAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		private static DelegateBridge __Hotfix0_DoApplyModifier;

		// Token: 0x0400ECAE RID: 60590
		[Token(Token = "0x400ECAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x998")]
		private static DelegateBridge __Hotfix0__DoApplyEPModifierInternal;

		// Token: 0x0400ECAF RID: 60591
		[Token(Token = "0x400ECAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		private static DelegateBridge __Hotfix0_OnBuffStart;

		// Token: 0x0400ECB0 RID: 60592
		[Token(Token = "0x400ECB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A8")]
		private static DelegateBridge __Hotfix0_OnBuffShowEffect;

		// Token: 0x0400ECB1 RID: 60593
		[Token(Token = "0x400ECB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B0")]
		private static DelegateBridge __Hotfix0_OnOtherBuffStart;

		// Token: 0x0400ECB2 RID: 60594
		[Token(Token = "0x400ECB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B8")]
		private static DelegateBridge __Hotfix0_OnBuffFinish;

		// Token: 0x0400ECB3 RID: 60595
		[Token(Token = "0x400ECB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		private static DelegateBridge __Hotfix0_OnBuffTrigger;

		// Token: 0x0400ECB4 RID: 60596
		[Token(Token = "0x400ECB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C8")]
		private static DelegateBridge __Hotfix0_OnBuffExtend;

		// Token: 0x0400ECB5 RID: 60597
		[Token(Token = "0x400ECB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		private static DelegateBridge __Hotfix0_OnAbilityStart;

		// Token: 0x0400ECB6 RID: 60598
		[Token(Token = "0x400ECB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D8")]
		private static DelegateBridge __Hotfix0_OnAbilityFinish;

		// Token: 0x0400ECB7 RID: 60599
		[Token(Token = "0x400ECB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		private static DelegateBridge __Hotfix0_OnBeforeAbilitySpellOn;

		// Token: 0x0400ECB8 RID: 60600
		[Token(Token = "0x400ECB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E8")]
		private static DelegateBridge __Hotfix0_OnAbilitySpellOn;

		// Token: 0x0400ECB9 RID: 60601
		[Token(Token = "0x400ECB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		private static DelegateBridge __Hotfix0_OnAbilityCastOnTarget;

		// Token: 0x0400ECBA RID: 60602
		[Token(Token = "0x400ECBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400ECBB RID: 60603
		[Token(Token = "0x400ECBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		private static DelegateBridge __Hotfix0__UpdateCachedAbilities;

		// Token: 0x0400ECBC RID: 60604
		[Token(Token = "0x400ECBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA08")]
		private static DelegateBridge __Hotfix0_OnAttributeDirty;

		// Token: 0x0400ECBD RID: 60605
		[Token(Token = "0x400ECBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		private static DelegateBridge __Hotfix0__OnAbnormalFlagDirty;

		// Token: 0x0400ECBE RID: 60606
		[Token(Token = "0x400ECBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA18")]
		private static DelegateBridge __Hotfix0__OnAbnormalComboDirty;

		// Token: 0x0400ECBF RID: 60607
		[Token(Token = "0x400ECBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400ECC0 RID: 60608
		[Token(Token = "0x400ECC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA28")]
		private static DelegateBridge __Hotfix0_OnMotionModeChanged;

		// Token: 0x0400ECC1 RID: 60609
		[Token(Token = "0x400ECC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		private static DelegateBridge __Hotfix0_OnDirectionChanged;

		// Token: 0x0400ECC2 RID: 60610
		[Token(Token = "0x400ECC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA38")]
		private static DelegateBridge __Hotfix0_OnAttackRangeChanged;

		// Token: 0x0400ECC3 RID: 60611
		[Token(Token = "0x400ECC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		private static DelegateBridge __Hotfix0_OnTargetKilled;

		// Token: 0x0400ECC4 RID: 60612
		[Token(Token = "0x400ECC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA48")]
		private static DelegateBridge __Hotfix0__VerifyAbilityDamageMiss;

		// Token: 0x0400ECC5 RID: 60613
		[Token(Token = "0x400ECC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x0400ECC6 RID: 60614
		[Token(Token = "0x400ECC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
		private static DelegateBridge __Hotfix0_OnTakeHeal;

		// Token: 0x0400ECC7 RID: 60615
		[Token(Token = "0x400ECC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		private static DelegateBridge __Hotfix0_OnTakeEPDamage;

		// Token: 0x0400ECC8 RID: 60616
		[Token(Token = "0x400ECC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA68")]
		private static DelegateBridge __Hotfix0_OnTriggerPalsy;

		// Token: 0x0400ECC9 RID: 60617
		[Token(Token = "0x400ECC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		private static DelegateBridge __Hotfix0_IfReasonIsDeath;

		// Token: 0x0400ECCA RID: 60618
		[Token(Token = "0x400ECCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA78")]
		private static DelegateBridge __Hotfix0_IfReasonIsHpZero;

		// Token: 0x0400ECCB RID: 60619
		[Token(Token = "0x400ECCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		private static DelegateBridge __Hotfix0_EmitEvent;

		// Token: 0x0400ECCC RID: 60620
		[Token(Token = "0x400ECCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA88")]
		private static DelegateBridge __Hotfix1_EmitEvent;

		// Token: 0x0400ECCD RID: 60621
		[Token(Token = "0x400ECCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA90")]
		private static DelegateBridge __Hotfix2_EmitEvent;

		// Token: 0x0400ECCE RID: 60622
		[Token(Token = "0x400ECCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA98")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0400ECCF RID: 60623
		[Token(Token = "0x400ECCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		private static DelegateBridge __Hotfix0_PlayDialogAnim;

		// Token: 0x0400ECD0 RID: 60624
		[Token(Token = "0x400ECD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA8")]
		private static DelegateBridge __Hotfix0_IsInHitRange;

		// Token: 0x0400ECD1 RID: 60625
		[Token(Token = "0x400ECD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
		private static DelegateBridge __Hotfix0_IsTargetInHitRange;

		// Token: 0x0400ECD2 RID: 60626
		[Token(Token = "0x400ECD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB8")]
		private static DelegateBridge __Hotfix0_RegisterHitRangeProvider;

		// Token: 0x0400ECD3 RID: 60627
		[Token(Token = "0x400ECD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		private static DelegateBridge __Hotfix0_UnregisterHitRangeProvider;

		// Token: 0x0400ECD4 RID: 60628
		[Token(Token = "0x400ECD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC8")]
		private static DelegateBridge __Hotfix0_CanDoAbilitySpellOn;

		// Token: 0x020021FF RID: 8703
		[Token(Token = "0x20021FF")]
		public class SpController : IHotfixable
		{
			// Token: 0x17001B94 RID: 7060
			// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x00050310 File Offset: 0x0004E510
			[Token(Token = "0x17001B94")]
			public bool isFull
			{
				[Token(Token = "0x600DB73")]
				[Address(RVA = "0x360E120", Offset = "0x360CD20", VA = "0x18360E120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001B95 RID: 7061
			// (get) Token: 0x0600DB74 RID: 56180 RVA: 0x00050328 File Offset: 0x0004E528
			[Token(Token = "0x17001B95")]
			public bool isTimerValid
			{
				[Token(Token = "0x600DB74")]
				[Address(RVA = "0x360E1E0", Offset = "0x360CDE0", VA = "0x18360E1E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001B96 RID: 7062
			// (get) Token: 0x0600DB75 RID: 56181 RVA: 0x00050340 File Offset: 0x0004E540
			[Token(Token = "0x17001B96")]
			public SpType spType
			{
				[Token(Token = "0x600DB75")]
				[Address(RVA = "0x360EA00", Offset = "0x360D600", VA = "0x18360EA00")]
				get
				{
					return SpType.NONE;
				}
			}

			// Token: 0x17001B97 RID: 7063
			// (get) Token: 0x0600DB76 RID: 56182 RVA: 0x00050358 File Offset: 0x0004E558
			[Token(Token = "0x17001B97")]
			public FP progressToFull
			{
				[Token(Token = "0x600DB76")]
				[Address(RVA = "0x360E3F0", Offset = "0x360CFF0", VA = "0x18360E3F0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001B98 RID: 7064
			// (get) Token: 0x0600DB77 RID: 56183 RVA: 0x00050370 File Offset: 0x0004E570
			[Token(Token = "0x17001B98")]
			public FP progressToReady
			{
				[Token(Token = "0x600DB77")]
				[Address(RVA = "0x360E710", Offset = "0x360D310", VA = "0x18360E710")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001B99 RID: 7065
			// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x00050388 File Offset: 0x0004E588
			[Token(Token = "0x17001B99")]
			public FP progressToNext
			{
				[Token(Token = "0x600DB78")]
				[Address(RVA = "0x360E580", Offset = "0x360D180", VA = "0x18360E580")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001B9A RID: 7066
			// (get) Token: 0x0600DB79 RID: 56185 RVA: 0x000503A0 File Offset: 0x0004E5A0
			[Token(Token = "0x17001B9A")]
			public FP progressLayer
			{
				[Token(Token = "0x600DB79")]
				[Address(RVA = "0x360E250", Offset = "0x360CE50", VA = "0x18360E250")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001B9B RID: 7067
			// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x000503B8 File Offset: 0x0004E5B8
			[Token(Token = "0x17001B9B")]
			public int spCost
			{
				[Token(Token = "0x600DB7A")]
				[Address(RVA = "0x360E980", Offset = "0x360D580", VA = "0x18360E980")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001B9C RID: 7068
			// (get) Token: 0x0600DB7B RID: 56187 RVA: 0x000503D0 File Offset: 0x0004E5D0
			[Token(Token = "0x17001B9C")]
			public bool spCostZero
			{
				[Token(Token = "0x600DB7B")]
				[Address(RVA = "0x360E8E0", Offset = "0x360D4E0", VA = "0x18360E8E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600DB7C RID: 56188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB7C")]
			[Address(RVA = "0x360D650", Offset = "0x360C250", VA = "0x18360D650")]
			public void MarkInvalid()
			{
			}

			// Token: 0x0600DB7D RID: 56189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB7D")]
			[Address(RVA = "0x360DA90", Offset = "0x360C690", VA = "0x18360DA90")]
			public void Reset(Entity owner, SpData data)
			{
			}

			// Token: 0x0600DB7E RID: 56190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB7E")]
			[Address(RVA = "0x360DA20", Offset = "0x360C620", VA = "0x18360DA20")]
			public void ResetSpTimer()
			{
			}

			// Token: 0x0600DB7F RID: 56191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB7F")]
			[Address(RVA = "0x360DC10", Offset = "0x360C810", VA = "0x18360DC10")]
			public void UpdateSpData(SpData data, bool onlyUpdateSpCost)
			{
			}

			// Token: 0x0600DB80 RID: 56192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB80")]
			[Address(RVA = "0x360D7C0", Offset = "0x360C3C0", VA = "0x18360D7C0")]
			public void OnTakeDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600DB81 RID: 56193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB81")]
			[Address(RVA = "0x360D6C0", Offset = "0x360C2C0", VA = "0x18360D6C0")]
			public void OnOutputAttackOrHeal(Ability ability)
			{
			}

			// Token: 0x0600DB82 RID: 56194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB82")]
			[Address(RVA = "0x360DD90", Offset = "0x360C990", VA = "0x18360DD90")]
			public void UpdateSpRecoveryPerSec(FP newValue, FP oldValue)
			{
			}

			// Token: 0x0600DB83 RID: 56195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB83")]
			[Address(RVA = "0x360D8F0", Offset = "0x360C4F0", VA = "0x18360D8F0")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600DB84 RID: 56196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB84")]
			[Address(RVA = "0x360DF50", Offset = "0x360CB50", VA = "0x18360DF50")]
			private void _RecoverMp(FP value, bool force = false)
			{
			}

			// Token: 0x0600DB85 RID: 56197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB85")]
			[Address(RVA = "0x360E050", Offset = "0x360CC50", VA = "0x18360E050")]
			public SpController()
			{
			}

			// Token: 0x0400ECD5 RID: 60629
			[Token(Token = "0x400ECD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SpType m_spType;

			// Token: 0x0400ECD6 RID: 60630
			[Token(Token = "0x400ECD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Entity m_owner;

			// Token: 0x0400ECD7 RID: 60631
			[Token(Token = "0x400ECD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ObscuredInt m_spCost;

			// Token: 0x0400ECD8 RID: 60632
			[Token(Token = "0x400ECD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float[] m_increments;

			// Token: 0x0400ECD9 RID: 60633
			[Token(Token = "0x400ECD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private PrecisePeriodicTimer m_spRecoverTimer;

			// Token: 0x0400ECDA RID: 60634
			[Token(Token = "0x400ECDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isFull;

			// Token: 0x0400ECDB RID: 60635
			[Token(Token = "0x400ECDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isTimerValid;

			// Token: 0x0400ECDC RID: 60636
			[Token(Token = "0x400ECDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_spType;

			// Token: 0x0400ECDD RID: 60637
			[Token(Token = "0x400ECDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_progressToFull;

			// Token: 0x0400ECDE RID: 60638
			[Token(Token = "0x400ECDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_progressToReady;

			// Token: 0x0400ECDF RID: 60639
			[Token(Token = "0x400ECDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_progressToNext;

			// Token: 0x0400ECE0 RID: 60640
			[Token(Token = "0x400ECE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_progressLayer;

			// Token: 0x0400ECE1 RID: 60641
			[Token(Token = "0x400ECE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_spCost;

			// Token: 0x0400ECE2 RID: 60642
			[Token(Token = "0x400ECE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_spCostZero;

			// Token: 0x0400ECE3 RID: 60643
			[Token(Token = "0x400ECE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_MarkInvalid;

			// Token: 0x0400ECE4 RID: 60644
			[Token(Token = "0x400ECE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400ECE5 RID: 60645
			[Token(Token = "0x400ECE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ResetSpTimer;

			// Token: 0x0400ECE6 RID: 60646
			[Token(Token = "0x400ECE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_UpdateSpData;

			// Token: 0x0400ECE7 RID: 60647
			[Token(Token = "0x400ECE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnTakeDamage;

			// Token: 0x0400ECE8 RID: 60648
			[Token(Token = "0x400ECE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnOutputAttackOrHeal;

			// Token: 0x0400ECE9 RID: 60649
			[Token(Token = "0x400ECE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_UpdateSpRecoveryPerSec;

			// Token: 0x0400ECEA RID: 60650
			[Token(Token = "0x400ECEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400ECEB RID: 60651
			[Token(Token = "0x400ECEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0__RecoverMp;

			// Token: 0x0400ECEC RID: 60652
			[Token(Token = "0x400ECEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002200 RID: 8704
		[Token(Token = "0x2002200")]
		public class EPController : Attributes.IAttributesModifier, IHotfixable
		{
			// Token: 0x17001B9D RID: 7069
			// (get) Token: 0x0600DB86 RID: 56198 RVA: 0x000503E8 File Offset: 0x0004E5E8
			// (set) Token: 0x0600DB87 RID: 56199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001B9D")]
			public bool isInBreakRecovery
			{
				[Token(Token = "0x600DB86")]
				[Address(RVA = "0x35F3400", Offset = "0x35F2000", VA = "0x1835F3400")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600DB87")]
				[Address(RVA = "0x35F3460", Offset = "0x35F2060", VA = "0x1835F3460")]
				set
				{
				}
			}

			// Token: 0x0600DB88 RID: 56200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB88")]
			[Address(RVA = "0x35F2AC0", Offset = "0x35F16C0", VA = "0x1835F2AC0")]
			public void Reset(Entity owner)
			{
			}

			// Token: 0x0600DB89 RID: 56201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB89")]
			[Address(RVA = "0x35F28E0", Offset = "0x35F14E0", VA = "0x1835F28E0")]
			public void OnFinish()
			{
			}

			// Token: 0x0600DB8A RID: 56202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB8A")]
			[Address(RVA = "0x35F2960", Offset = "0x35F1560", VA = "0x1835F2960")]
			public void OnTick()
			{
			}

			// Token: 0x0600DB8B RID: 56203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB8B")]
			[Address(RVA = "0x35F2C60", Offset = "0x35F1860", VA = "0x1835F2C60")]
			private void _CreateBrokenBuff(EPBreakBuffData data, float epBreakDuration)
			{
			}

			// Token: 0x0600DB8C RID: 56204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB8C")]
			[Address(RVA = "0x35F2F50", Offset = "0x35F1B50", VA = "0x1835F2F50")]
			private void _StartEPRecovery(float recoverTime)
			{
			}

			// Token: 0x0600DB8D RID: 56205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB8D")]
			[Address(RVA = "0x35F24C0", Offset = "0x35F10C0", VA = "0x1835F24C0")]
			public void OnElementBreak(ElementType curEPDamageType)
			{
			}

			// Token: 0x17001B9E RID: 7070
			// (get) Token: 0x0600DB8E RID: 56206 RVA: 0x00050400 File Offset: 0x0004E600
			[Token(Token = "0x17001B9E")]
			public long attributeMask
			{
				[Token(Token = "0x600DB8E")]
				[Address(RVA = "0x35F33A0", Offset = "0x35F1FA0", VA = "0x1835F33A0", Slot = "4")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001B9F RID: 7071
			// (get) Token: 0x0600DB8F RID: 56207 RVA: 0x00050418 File Offset: 0x0004E618
			[Token(Token = "0x17001B9F")]
			public long abnormalFlagMask
			{
				[Token(Token = "0x600DB8F")]
				[Address(RVA = "0x35F32C0", Offset = "0x35F1EC0", VA = "0x1835F32C0", Slot = "5")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001BA0 RID: 7072
			// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x00050430 File Offset: 0x0004E630
			[Token(Token = "0x17001BA0")]
			public long abnormalImmuneMask
			{
				[Token(Token = "0x600DB90")]
				[Address(RVA = "0x35F3340", Offset = "0x35F1F40", VA = "0x1835F3340", Slot = "6")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001BA1 RID: 7073
			// (get) Token: 0x0600DB91 RID: 56209 RVA: 0x00050448 File Offset: 0x0004E648
			[Token(Token = "0x17001BA1")]
			public long abnormalAntiMask
			{
				[Token(Token = "0x600DB91")]
				[Address(RVA = "0x35F31A0", Offset = "0x35F1DA0", VA = "0x1835F31A0", Slot = "7")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001BA2 RID: 7074
			// (get) Token: 0x0600DB92 RID: 56210 RVA: 0x00050460 File Offset: 0x0004E660
			[Token(Token = "0x17001BA2")]
			public long abnormalComboMask
			{
				[Token(Token = "0x600DB92")]
				[Address(RVA = "0x35F3260", Offset = "0x35F1E60", VA = "0x1835F3260", Slot = "8")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001BA3 RID: 7075
			// (get) Token: 0x0600DB93 RID: 56211 RVA: 0x00050478 File Offset: 0x0004E678
			[Token(Token = "0x17001BA3")]
			public long abnormalComboImmuneMask
			{
				[Token(Token = "0x600DB93")]
				[Address(RVA = "0x35F3200", Offset = "0x35F1E00", VA = "0x1835F3200", Slot = "9")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x0600DB94 RID: 56212 RVA: 0x00050490 File Offset: 0x0004E690
			[Token(Token = "0x600DB94")]
			[Address(RVA = "0x35F23E0", Offset = "0x35F0FE0", VA = "0x1835F23E0", Slot = "10")]
			public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
			{
				return default(bool);
			}

			// Token: 0x0600DB95 RID: 56213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB95")]
			[Address(RVA = "0x35F3140", Offset = "0x35F1D40", VA = "0x1835F3140")]
			public EPController()
			{
			}

			// Token: 0x0400ECED RID: 60653
			[Token(Token = "0x400ECED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ElementType recoveryType;

			// Token: 0x0400ECEE RID: 60654
			[Token(Token = "0x400ECEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Entity m_owner;

			// Token: 0x0400ECEF RID: 60655
			[Token(Token = "0x400ECEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool m_isInBreakRecovery;

			// Token: 0x0400ECF0 RID: 60656
			[Token(Token = "0x400ECF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BattleTweenMgr.Tween m_tween;

			// Token: 0x0400ECF1 RID: 60657
			[Token(Token = "0x400ECF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isInBreakRecovery;

			// Token: 0x0400ECF2 RID: 60658
			[Token(Token = "0x400ECF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isInBreakRecovery;

			// Token: 0x0400ECF3 RID: 60659
			[Token(Token = "0x400ECF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400ECF4 RID: 60660
			[Token(Token = "0x400ECF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnFinish;

			// Token: 0x0400ECF5 RID: 60661
			[Token(Token = "0x400ECF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400ECF6 RID: 60662
			[Token(Token = "0x400ECF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__CreateBrokenBuff;

			// Token: 0x0400ECF7 RID: 60663
			[Token(Token = "0x400ECF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__StartEPRecovery;

			// Token: 0x0400ECF8 RID: 60664
			[Token(Token = "0x400ECF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnElementBreak;

			// Token: 0x0400ECF9 RID: 60665
			[Token(Token = "0x400ECF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_attributeMask;

			// Token: 0x0400ECFA RID: 60666
			[Token(Token = "0x400ECFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

			// Token: 0x0400ECFB RID: 60667
			[Token(Token = "0x400ECFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

			// Token: 0x0400ECFC RID: 60668
			[Token(Token = "0x400ECFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

			// Token: 0x0400ECFD RID: 60669
			[Token(Token = "0x400ECFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_abnormalComboMask;

			// Token: 0x0400ECFE RID: 60670
			[Token(Token = "0x400ECFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

			// Token: 0x0400ECFF RID: 60671
			[Token(Token = "0x400ECFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GetValue;

			// Token: 0x0400ED00 RID: 60672
			[Token(Token = "0x400ED00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002201 RID: 8705
		[Token(Token = "0x2002201")]
		public class ShieldUIController : IHotfixable
		{
			// Token: 0x17001BA4 RID: 7076
			// (get) Token: 0x0600DB98 RID: 56216 RVA: 0x000504A8 File Offset: 0x0004E6A8
			[Token(Token = "0x17001BA4")]
			public FP shieldToShow
			{
				[Token(Token = "0x600DB98")]
				[Address(RVA = "0x3629CE0", Offset = "0x36288E0", VA = "0x183629CE0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x0600DB99 RID: 56217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB99")]
			[Address(RVA = "0x3629BD0", Offset = "0x36287D0", VA = "0x183629BD0")]
			public void Reset(Entity owner)
			{
			}

			// Token: 0x0600DB9A RID: 56218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9A")]
			[Address(RVA = "0x3629A90", Offset = "0x3628690", VA = "0x183629A90")]
			public void CalculateShieldData()
			{
			}

			// Token: 0x0600DB9B RID: 56219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9B")]
			[Address(RVA = "0x3629C80", Offset = "0x3628880", VA = "0x183629C80")]
			public ShieldUIController()
			{
			}

			// Token: 0x0400ED01 RID: 60673
			[Token(Token = "0x400ED01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Entity m_owner;

			// Token: 0x0400ED02 RID: 60674
			[Token(Token = "0x400ED02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private FP m_shieldToShow;

			// Token: 0x0400ED03 RID: 60675
			[Token(Token = "0x400ED03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_shieldToShow;

			// Token: 0x0400ED04 RID: 60676
			[Token(Token = "0x400ED04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400ED05 RID: 60677
			[Token(Token = "0x400ED05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalculateShieldData;

			// Token: 0x0400ED06 RID: 60678
			[Token(Token = "0x400ED06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02002202 RID: 8706
			[Token(Token = "0x2002202")]
			public struct ShieldData
			{
				// Token: 0x0400ED07 RID: 60679
				[Token(Token = "0x400ED07")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public DamageTypeMask shieldMask;

				// Token: 0x0400ED08 RID: 60680
				[Token(Token = "0x400ED08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public FP value;
			}
		}

		// Token: 0x02002203 RID: 8707
		[Token(Token = "0x2002203")]
		public class BuffEffectHolder
		{
			// Token: 0x0600DB9C RID: 56220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9C")]
			[Address(RVA = "0x361D3C0", Offset = "0x361BFC0", VA = "0x18361D3C0")]
			public BuffEffectHolder(Effect effect)
			{
			}

			// Token: 0x0600DB9D RID: 56221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9D")]
			[Address(RVA = "0x361D350", Offset = "0x361BF50", VA = "0x18361D350")]
			public void Reset(Effect effect)
			{
			}

			// Token: 0x0400ED09 RID: 60681
			[Token(Token = "0x400ED09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int refCounter;

			// Token: 0x0400ED0A RID: 60682
			[Token(Token = "0x400ED0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ObjectPtr<Effect> effect;
		}

		// Token: 0x02002204 RID: 8708
		[Token(Token = "0x2002204")]
		public class AnimBundle
		{
			// Token: 0x0600DB9E RID: 56222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimBundle()
			{
			}

			// Token: 0x0400ED0B RID: 60683
			[Token(Token = "0x400ED0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animKey;

			// Token: 0x0400ED0C RID: 60684
			[Token(Token = "0x400ED0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string loopIdleAnimKey;

			// Token: 0x0400ED0D RID: 60685
			[Token(Token = "0x400ED0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SharedConsts.Direction direction;

			// Token: 0x0400ED0E RID: 60686
			[Token(Token = "0x400ED0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float speed;

			// Token: 0x0400ED0F RID: 60687
			[Token(Token = "0x400ED0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool noIdleWhenFinish;
		}

		// Token: 0x02002205 RID: 8709
		[Token(Token = "0x2002205")]
		public abstract class FriendComponent : MonoBehaviour
		{
			// Token: 0x0600DB9F RID: 56223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB9F")]
			[Address(RVA = "0x361F850", Offset = "0x361E450", VA = "0x18361F850")]
			protected void AttachAbilityToEntity(Entity entity, Ability ability)
			{
			}

			// Token: 0x0600DBA0 RID: 56224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA0")]
			[Address(RVA = "0x361F880", Offset = "0x361E480", VA = "0x18361F880")]
			protected void DetachAbilityFromEntity(Entity entity, Ability ability)
			{
			}

			// Token: 0x0600DBA1 RID: 56225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA1")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected FriendComponent()
			{
			}
		}

		// Token: 0x02002206 RID: 8710
		[Token(Token = "0x2002206")]
		public enum Event
		{
			// Token: 0x0400ED11 RID: 60689
			[Token(Token = "0x400ED11")]
			ON_BORN,
			// Token: 0x0400ED12 RID: 60690
			[Token(Token = "0x400ED12")]
			ON_DEATH,
			// Token: 0x0400ED13 RID: 60691
			[Token(Token = "0x400ED13")]
			ON_FINISH,
			// Token: 0x0400ED14 RID: 60692
			[Token(Token = "0x400ED14")]
			ON_LOCATE,
			// Token: 0x0400ED15 RID: 60693
			[Token(Token = "0x400ED15")]
			ON_STATE_CHANGE,
			// Token: 0x0400ED16 RID: 60694
			[Token(Token = "0x400ED16")]
			ON_USE_SKILL,
			// Token: 0x0400ED17 RID: 60695
			[Token(Token = "0x400ED17")]
			ON_SKILL_START,
			// Token: 0x0400ED18 RID: 60696
			[Token(Token = "0x400ED18")]
			ON_SKILL_FINISH,
			// Token: 0x0400ED19 RID: 60697
			[Token(Token = "0x400ED19")]
			ON_BEFORE_APPLYING_MODIFIER,
			// Token: 0x0400ED1A RID: 60698
			[Token(Token = "0x400ED1A")]
			ON_APPLYING_MODIFIER,
			// Token: 0x0400ED1B RID: 60699
			[Token(Token = "0x400ED1B")]
			ON_APPLIED_MODIFIER,
			// Token: 0x0400ED1C RID: 60700
			[Token(Token = "0x400ED1C")]
			ON_OUTPUT_MODIFIER,
			// Token: 0x0400ED1D RID: 60701
			[Token(Token = "0x400ED1D")]
			ON_TAKE_DAMAGE,
			// Token: 0x0400ED1E RID: 60702
			[Token(Token = "0x400ED1E")]
			ON_TAKE_HEAL,
			// Token: 0x0400ED1F RID: 60703
			[Token(Token = "0x400ED1F")]
			ON_OUTPUT_DAMAGE,
			// Token: 0x0400ED20 RID: 60704
			[Token(Token = "0x400ED20")]
			ON_EVADE_DAMAGE,
			// Token: 0x0400ED21 RID: 60705
			[Token(Token = "0x400ED21")]
			ON_BUFF_START,
			// Token: 0x0400ED22 RID: 60706
			[Token(Token = "0x400ED22")]
			ON_BUFF_FINISH,
			// Token: 0x0400ED23 RID: 60707
			[Token(Token = "0x400ED23")]
			ON_BUFF_TRIGGER,
			// Token: 0x0400ED24 RID: 60708
			[Token(Token = "0x400ED24")]
			ON_ATTACK_EVENT,
			// Token: 0x0400ED25 RID: 60709
			[Token(Token = "0x400ED25")]
			ON_ATTACK_FINISHED_EVENT,
			// Token: 0x0400ED26 RID: 60710
			[Token(Token = "0x400ED26")]
			ON_ABILITY_ANIM_END_EVENT,
			// Token: 0x0400ED27 RID: 60711
			[Token(Token = "0x400ED27")]
			ON_SHOW_DEBUG_LOG,
			// Token: 0x0400ED28 RID: 60712
			[Token(Token = "0x400ED28")]
			ON_APPEAR_OR_DISAPPEAR,
			// Token: 0x0400ED29 RID: 60713
			[Token(Token = "0x400ED29")]
			ON_BLOCKEE_CHANGED,
			// Token: 0x0400ED2A RID: 60714
			[Token(Token = "0x400ED2A")]
			ON_STUNNED,
			// Token: 0x0400ED2B RID: 60715
			[Token(Token = "0x400ED2B")]
			ON_FROZEN,
			// Token: 0x0400ED2C RID: 60716
			[Token(Token = "0x400ED2C")]
			ON_ATTACK_CHECKPOINT,
			// Token: 0x0400ED2D RID: 60717
			[Token(Token = "0x400ED2D")]
			ON_REBORN_AFTER_FAKE_DEATH,
			// Token: 0x0400ED2E RID: 60718
			[Token(Token = "0x400ED2E")]
			ON_AFTER_REBORN,
			// Token: 0x0400ED2F RID: 60719
			[Token(Token = "0x400ED2F")]
			ON_BEFORE_APPEAR_OR_DISAPPEAR,
			// Token: 0x0400ED30 RID: 60720
			[Token(Token = "0x400ED30")]
			ON_MAP_LAYER_CHANGED,
			// Token: 0x0400ED31 RID: 60721
			[Token(Token = "0x400ED31")]
			ON_FRICTION_UPDATED,
			// Token: 0x0400ED32 RID: 60722
			[Token(Token = "0x400ED32")]
			ON_LEVITATE,
			// Token: 0x0400ED33 RID: 60723
			[Token(Token = "0x400ED33")]
			ON_ABNORMALFLAG_DIRTY,
			// Token: 0x0400ED34 RID: 60724
			[Token(Token = "0x400ED34")]
			ON_SHOW_MESSAGE,
			// Token: 0x0400ED35 RID: 60725
			[Token(Token = "0x400ED35")]
			ON_HUD_CREATED,
			// Token: 0x0400ED36 RID: 60726
			[Token(Token = "0x400ED36")]
			ON_ACTIVATE_EFFECT_EVENT,
			// Token: 0x0400ED37 RID: 60727
			[Token(Token = "0x400ED37")]
			ON_DEACTIVATE_EFFECT_EVENT,
			// Token: 0x0400ED38 RID: 60728
			[Token(Token = "0x400ED38")]
			ON_PLAY_DIALOG_ANIM,
			// Token: 0x0400ED39 RID: 60729
			[Token(Token = "0x400ED39")]
			ON_CREATE_PROJECTILE,
			// Token: 0x0400ED3A RID: 60730
			[Token(Token = "0x400ED3A")]
			ON_PROJECTILE_REACHED,
			// Token: 0x0400ED3B RID: 60731
			[Token(Token = "0x400ED3B")]
			ON_EP_BREAK_START,
			// Token: 0x0400ED3C RID: 60732
			[Token(Token = "0x400ED3C")]
			ON_EP_BREAK_FINISH,
			// Token: 0x0400ED3D RID: 60733
			[Token(Token = "0x400ED3D")]
			ON_ENTITY_GET_CLICKED,
			// Token: 0x0400ED3E RID: 60734
			[Token(Token = "0x400ED3E")]
			ON_TOGGLE_SKILL_START,
			// Token: 0x0400ED3F RID: 60735
			[Token(Token = "0x400ED3F")]
			ON_COLLIDE_WITH_HIGHLAND,
			// Token: 0x0400ED40 RID: 60736
			[Token(Token = "0x400ED40")]
			ON_SIDE_SWITCH,
			// Token: 0x0400ED41 RID: 60737
			[Token(Token = "0x400ED41")]
			ON_DOZE_CHANGED,
			// Token: 0x0400ED42 RID: 60738
			[Token(Token = "0x400ED42")]
			E_NUM
		}

		// Token: 0x02002207 RID: 8711
		[Token(Token = "0x2002207")]
		public enum FinishReason
		{
			// Token: 0x0400ED44 RID: 60740
			[Token(Token = "0x400ED44")]
			NONE,
			// Token: 0x0400ED45 RID: 60741
			[Token(Token = "0x400ED45")]
			REACH_EXIT,
			// Token: 0x0400ED46 RID: 60742
			[Token(Token = "0x400ED46")]
			HP_ZERO,
			// Token: 0x0400ED47 RID: 60743
			[Token(Token = "0x400ED47")]
			FALLDOWN,
			// Token: 0x0400ED48 RID: 60744
			[Token(Token = "0x400ED48")]
			WITHDRAW,
			// Token: 0x0400ED49 RID: 60745
			[Token(Token = "0x400ED49")]
			DEADLIKE_WITHDRAW,
			// Token: 0x0400ED4A RID: 60746
			[Token(Token = "0x400ED4A")]
			SILENT_WITHDRAW,
			// Token: 0x0400ED4B RID: 60747
			[Token(Token = "0x400ED4B")]
			OTHER,
			// Token: 0x0400ED4C RID: 60748
			[Token(Token = "0x400ED4C")]
			HP_ZERO_WITH_NO_SOURCE,
			// Token: 0x0400ED4D RID: 60749
			[Token(Token = "0x400ED4D")]
			REPLACED,
			// Token: 0x0400ED4E RID: 60750
			[Token(Token = "0x400ED4E")]
			RESPAWN_SELF,
			// Token: 0x0400ED4F RID: 60751
			[Token(Token = "0x400ED4F")]
			MOVE_LIKE_RESPAWN_SELF,
			// Token: 0x0400ED50 RID: 60752
			[Token(Token = "0x400ED50")]
			MOVE_LIKE_RESPAWN_EXTERNAL
		}

		// Token: 0x02002208 RID: 8712
		[Token(Token = "0x2002208")]
		public enum MountPointType
		{
			// Token: 0x0400ED52 RID: 60754
			[Token(Token = "0x400ED52")]
			FOOT,
			// Token: 0x0400ED53 RID: 60755
			[Token(Token = "0x400ED53")]
			HIT,
			// Token: 0x0400ED54 RID: 60756
			[Token(Token = "0x400ED54")]
			MUZZLE,
			// Token: 0x0400ED55 RID: 60757
			[Token(Token = "0x400ED55")]
			HEAD,
			// Token: 0x0400ED56 RID: 60758
			[Token(Token = "0x400ED56")]
			UI,
			// Token: 0x0400ED57 RID: 60759
			[Token(Token = "0x400ED57")]
			SPECIAL_0,
			// Token: 0x0400ED58 RID: 60760
			[Token(Token = "0x400ED58")]
			SPECIAL_1,
			// Token: 0x0400ED59 RID: 60761
			[Token(Token = "0x400ED59")]
			GROUND,
			// Token: 0x0400ED5A RID: 60762
			[Token(Token = "0x400ED5A")]
			SPECIAL_2,
			// Token: 0x0400ED5B RID: 60763
			[Token(Token = "0x400ED5B")]
			SPECIAL_3,
			// Token: 0x0400ED5C RID: 60764
			[Token(Token = "0x400ED5C")]
			SPECIAL_4,
			// Token: 0x0400ED5D RID: 60765
			[Token(Token = "0x400ED5D")]
			SPECIAL_5,
			// Token: 0x0400ED5E RID: 60766
			[Token(Token = "0x400ED5E")]
			SPECIAL_6,
			// Token: 0x0400ED5F RID: 60767
			[Token(Token = "0x400ED5F")]
			SPECIAL_7,
			// Token: 0x0400ED60 RID: 60768
			[Token(Token = "0x400ED60")]
			SPECIAL_8,
			// Token: 0x0400ED61 RID: 60769
			[Token(Token = "0x400ED61")]
			SPECIAL_9,
			// Token: 0x0400ED62 RID: 60770
			[Token(Token = "0x400ED62")]
			SPECIAL_10,
			// Token: 0x0400ED63 RID: 60771
			[Token(Token = "0x400ED63")]
			SPECIAL_11,
			// Token: 0x0400ED64 RID: 60772
			[Token(Token = "0x400ED64")]
			SPECIAL_12,
			// Token: 0x0400ED65 RID: 60773
			[Token(Token = "0x400ED65")]
			SPECIAL_13,
			// Token: 0x0400ED66 RID: 60774
			[Token(Token = "0x400ED66")]
			SPECIAL_14,
			// Token: 0x0400ED67 RID: 60775
			[Token(Token = "0x400ED67")]
			SPECIAL_15
		}

		// Token: 0x02002209 RID: 8713
		[Token(Token = "0x2002209")]
		[Serializable]
		public class MountPointGroup
		{
			// Token: 0x0600DBA2 RID: 56226 RVA: 0x000504C0 File Offset: 0x0004E6C0
			[Token(Token = "0x600DBA2")]
			[Address(RVA = "0x3629750", Offset = "0x3628350", VA = "0x183629750")]
			public Entity.MountPointType GetNextMountPoint()
			{
				return Entity.MountPointType.FOOT;
			}

			// Token: 0x0600DBA3 RID: 56227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MountPointGroup()
			{
			}

			// Token: 0x0400ED68 RID: 60776
			[Token(Token = "0x400ED68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entity.MountPointGroup.LoopType loopType;

			// Token: 0x0400ED69 RID: 60777
			[Token(Token = "0x400ED69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Entity.MountPointType[] mountPoints;

			// Token: 0x0400ED6A RID: 60778
			[Token(Token = "0x400ED6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			private int m_index;

			// Token: 0x0200220A RID: 8714
			[Token(Token = "0x200220A")]
			public enum LoopType
			{
				// Token: 0x0400ED6C RID: 60780
				[Token(Token = "0x400ED6C")]
				RANDOM,
				// Token: 0x0400ED6D RID: 60781
				[Token(Token = "0x400ED6D")]
				LOOP
			}
		}

		// Token: 0x0200220B RID: 8715
		[Token(Token = "0x200220B")]
		public interface IHitRangeProvider : IHotfixable
		{
			// Token: 0x0600DBA4 RID: 56228
			[Token(Token = "0x600DBA4")]
			bool IsInHitRange(Entity.HitRangeOption option);

			// Token: 0x0600DBA5 RID: 56229
			[Token(Token = "0x600DBA5")]
			bool IsTargetIn(Entity.HitRangeOption option);

			// Token: 0x17001BA5 RID: 7077
			// (get) Token: 0x0600DBA6 RID: 56230
			[Token(Token = "0x17001BA5")]
			string providerId { [Token(Token = "0x600DBA6")] get; }
		}

		// Token: 0x0200220C RID: 8716
		[Token(Token = "0x200220C")]
		private class HitRangeManager : IHotfixable
		{
			// Token: 0x0600DBA7 RID: 56231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA7")]
			[Address(RVA = "0x361FFC0", Offset = "0x361EBC0", VA = "0x18361FFC0")]
			public void Reset()
			{
			}

			// Token: 0x0600DBA8 RID: 56232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA8")]
			[Address(RVA = "0x361FE90", Offset = "0x361EA90", VA = "0x18361FE90")]
			public void Register(string id, Entity.IHitRangeProvider provider)
			{
			}

			// Token: 0x0600DBA9 RID: 56233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBA9")]
			[Address(RVA = "0x3620040", Offset = "0x361EC40", VA = "0x183620040")]
			public void Unregister(string id)
			{
			}

			// Token: 0x0600DBAA RID: 56234 RVA: 0x000504D8 File Offset: 0x0004E6D8
			[Token(Token = "0x600DBAA")]
			[Address(RVA = "0x361FBA0", Offset = "0x361E7A0", VA = "0x18361FBA0")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600DBAB RID: 56235 RVA: 0x000504F0 File Offset: 0x0004E6F0
			[Token(Token = "0x600DBAB")]
			[Address(RVA = "0x361F8B0", Offset = "0x361E4B0", VA = "0x18361F8B0")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600DBAC RID: 56236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBAC")]
			[Address(RVA = "0x36200D0", Offset = "0x361ECD0", VA = "0x1836200D0")]
			public HitRangeManager()
			{
			}

			// Token: 0x0400ED6E RID: 60782
			[Token(Token = "0x400ED6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, Entity.IHitRangeProvider> m_providers;

			// Token: 0x0400ED6F RID: 60783
			[Token(Token = "0x400ED6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400ED70 RID: 60784
			[Token(Token = "0x400ED70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Register;

			// Token: 0x0400ED71 RID: 60785
			[Token(Token = "0x400ED71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Unregister;

			// Token: 0x0400ED72 RID: 60786
			[Token(Token = "0x400ED72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsTargetIn;

			// Token: 0x0400ED73 RID: 60787
			[Token(Token = "0x400ED73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x0400ED74 RID: 60788
			[Token(Token = "0x400ED74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200220D RID: 8717
		[Token(Token = "0x200220D")]
		public struct HitRangeOption
		{
			// Token: 0x0400ED75 RID: 60789
			[Token(Token = "0x400ED75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GridPosition pos;

			// Token: 0x0400ED76 RID: 60790
			[Token(Token = "0x400ED76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ObjectPtr<Entity> sourceEntity;

			// Token: 0x0400ED77 RID: 60791
			[Token(Token = "0x400ED77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ObjectPtr<Entity> targetEntity;

			// Token: 0x0400ED78 RID: 60792
			[Token(Token = "0x400ED78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectPtr<Tile> targetTile;

			// Token: 0x0400ED79 RID: 60793
			[Token(Token = "0x400ED79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SideType sourceSide;

			// Token: 0x0400ED7A RID: 60794
			[Token(Token = "0x400ED7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public ActionPurposeMask purposeMask;
		}
	}
}

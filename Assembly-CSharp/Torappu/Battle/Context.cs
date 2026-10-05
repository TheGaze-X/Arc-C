using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021B9 RID: 8633
	[Token(Token = "0x20021B9")]
	public class Context
	{
		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600D77A RID: 55162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A30")]
		public Context.ContextPtrStack<Entity> source
		{
			[Token(Token = "0x600D77A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600D77B RID: 55163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A31")]
		public Context.ContextPtrStack<Entity> target
		{
			[Token(Token = "0x600D77B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A32")]
		public Context.ContextPtrStack<Buff> buff
		{
			[Token(Token = "0x600D77C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x0600D77D RID: 55165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A33")]
		public Context.ContextValueStack<Ability> ability
		{
			[Token(Token = "0x600D77D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x0600D77E RID: 55166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A34")]
		public Context.ContextValueStack<Modifier> modifier
		{
			[Token(Token = "0x600D77E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x0600D77F RID: 55167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A35")]
		public Context.ContextPtrStack<Projectile> projectile
		{
			[Token(Token = "0x600D77F")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600D780 RID: 55168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A36")]
		public Context.ContextPtrStack<Tile> tile
		{
			[Token(Token = "0x600D780")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600D781 RID: 55169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A37")]
		public Context.ContextValueStack<BattleFormula.AttackInfo> atkInfo
		{
			[Token(Token = "0x600D781")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600D782 RID: 55170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A38")]
		public Context.ContextValueStack<Entity> mainTarget
		{
			[Token(Token = "0x600D782")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600D783 RID: 55171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A39")]
		public Context.ContextPtrStack<Buff> mainBuff
		{
			[Token(Token = "0x600D783")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D784 RID: 55172 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		[Token(Token = "0x600D784")]
		[Address(RVA = "0x35CC580", Offset = "0x35CB180", VA = "0x1835CC580")]
		public Context.Snapshot TakeSnapshot()
		{
			return default(Context.Snapshot);
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D785")]
		[Address(RVA = "0x35CC370", Offset = "0x35CAF70", VA = "0x1835CC370")]
		public Context.ChangeGuard BeginChangeGard()
		{
			return null;
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D786")]
		[Address(RVA = "0x35CC410", Offset = "0x35CB010", VA = "0x1835CC410")]
		public void Clear()
		{
		}

		// Token: 0x0600D787 RID: 55175 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		[Token(Token = "0x600D787")]
		[Address(RVA = "0x35CC850", Offset = "0x35CB450", VA = "0x1835CC850")]
		private Context.Snapshot _DuplicateAll()
		{
			return default(Context.Snapshot);
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D788")]
		[Address(RVA = "0x35CD0A0", Offset = "0x35CBCA0", VA = "0x1835CD0A0")]
		private void _PopAll()
		{
		}

		// Token: 0x0600D789 RID: 55177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D789")]
		[Address(RVA = "0x35CD220", Offset = "0x35CBE20", VA = "0x1835CD220")]
		public Context()
		{
		}

		// Token: 0x0400E80F RID: 59407
		[Token(Token = "0x400E80F")]
		private const int INITIAL_STACK_CAPACITY = 100;

		// Token: 0x0400E810 RID: 59408
		[Token(Token = "0x400E810")]
		[FieldOffset(Offset = "0x10")]
		private Context.ContextPtrStack<Entity> m_source;

		// Token: 0x0400E811 RID: 59409
		[Token(Token = "0x400E811")]
		[FieldOffset(Offset = "0x18")]
		private Context.ContextPtrStack<Entity> m_target;

		// Token: 0x0400E812 RID: 59410
		[Token(Token = "0x400E812")]
		[FieldOffset(Offset = "0x20")]
		private Context.ContextPtrStack<Buff> m_buff;

		// Token: 0x0400E813 RID: 59411
		[Token(Token = "0x400E813")]
		[FieldOffset(Offset = "0x28")]
		private Context.ContextValueStack<Ability> m_ability;

		// Token: 0x0400E814 RID: 59412
		[Token(Token = "0x400E814")]
		[FieldOffset(Offset = "0x30")]
		private Context.ContextValueStack<Modifier> m_modifier;

		// Token: 0x0400E815 RID: 59413
		[Token(Token = "0x400E815")]
		[FieldOffset(Offset = "0x38")]
		private Context.ContextPtrStack<Projectile> m_projectile;

		// Token: 0x0400E816 RID: 59414
		[Token(Token = "0x400E816")]
		[FieldOffset(Offset = "0x40")]
		private Context.ContextPtrStack<Tile> m_tile;

		// Token: 0x0400E817 RID: 59415
		[Token(Token = "0x400E817")]
		[FieldOffset(Offset = "0x48")]
		private Context.ContextValueStack<BattleFormula.AttackInfo> m_atkInfo;

		// Token: 0x0400E818 RID: 59416
		[Token(Token = "0x400E818")]
		[FieldOffset(Offset = "0x50")]
		private Context.ContextValueStack<Entity> m_mainTarget;

		// Token: 0x0400E819 RID: 59417
		[Token(Token = "0x400E819")]
		[FieldOffset(Offset = "0x58")]
		private Context.ContextPtrStack<Buff> m_mainBuff;

		// Token: 0x020021BA RID: 8634
		[Token(Token = "0x20021BA")]
		[LuaCallCSharp(GenFlag.No)]
		[GCOptimize(OptimizeFlag.Default)]
		public struct Snapshot
		{
			// Token: 0x0400E81A RID: 59418
			[Token(Token = "0x400E81A")]
			[FieldOffset(Offset = "0x0")]
			public Entity source;

			// Token: 0x0400E81B RID: 59419
			[Token(Token = "0x400E81B")]
			[FieldOffset(Offset = "0x8")]
			public Entity target;

			// Token: 0x0400E81C RID: 59420
			[Token(Token = "0x400E81C")]
			[FieldOffset(Offset = "0x10")]
			public Buff buff;

			// Token: 0x0400E81D RID: 59421
			[Token(Token = "0x400E81D")]
			[FieldOffset(Offset = "0x18")]
			public Ability ability;

			// Token: 0x0400E81E RID: 59422
			[Token(Token = "0x400E81E")]
			[FieldOffset(Offset = "0x20")]
			public Modifier modifier;

			// Token: 0x0400E81F RID: 59423
			[Token(Token = "0x400E81F")]
			[FieldOffset(Offset = "0xA8")]
			public Projectile projectile;

			// Token: 0x0400E820 RID: 59424
			[Token(Token = "0x400E820")]
			[FieldOffset(Offset = "0xB0")]
			public Tile tile;

			// Token: 0x0400E821 RID: 59425
			[Token(Token = "0x400E821")]
			[FieldOffset(Offset = "0xB8")]
			public Entity mainTarget;

			// Token: 0x0400E822 RID: 59426
			[Token(Token = "0x400E822")]
			[FieldOffset(Offset = "0xC0")]
			public BattleFormula.AttackInfo atkInfo;

			// Token: 0x0400E823 RID: 59427
			[Token(Token = "0x400E823")]
			[FieldOffset(Offset = "0xE8")]
			public Buff mainBuff;
		}

		// Token: 0x020021BB RID: 8635
		[Token(Token = "0x20021BB")]
		public class ContextPtrStack<T> : Stack<ObjectPtr<T>> where T : class, IPtrObject
		{
			// Token: 0x0600D78A RID: 55178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D78A")]
			public ContextPtrStack()
			{
			}

			// Token: 0x17001A3A RID: 6714
			// (get) Token: 0x0600D78B RID: 55179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A3A")]
			public T value
			{
				[Token(Token = "0x600D78B")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D78C RID: 55180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D78C")]
			public void Push(T obj)
			{
			}

			// Token: 0x0600D78D RID: 55181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D78D")]
			public new T Pop()
			{
				return null;
			}

			// Token: 0x0600D78E RID: 55182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D78E")]
			public new T Peek()
			{
				return null;
			}
		}

		// Token: 0x020021BC RID: 8636
		[Token(Token = "0x20021BC")]
		public class ContextValueStack<T> : Stack<T>
		{
			// Token: 0x0600D78F RID: 55183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D78F")]
			public ContextValueStack()
			{
			}

			// Token: 0x17001A3B RID: 6715
			// (get) Token: 0x0600D790 RID: 55184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A3B")]
			public T value
			{
				[Token(Token = "0x600D790")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D791 RID: 55185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D791")]
			public new T Pop()
			{
				return null;
			}

			// Token: 0x0600D792 RID: 55186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D792")]
			public new T Peek()
			{
				return null;
			}
		}

		// Token: 0x020021BD RID: 8637
		[Token(Token = "0x20021BD")]
		public class ChangeGuard : IDisposable
		{
			// Token: 0x17001A3C RID: 6716
			// (get) Token: 0x0600D793 RID: 55187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A3C")]
			public Context context
			{
				[Token(Token = "0x600D793")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D794 RID: 55188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D794")]
			[Address(RVA = "0x35C9660", Offset = "0x35C8260", VA = "0x1835C9660")]
			public ChangeGuard(Context context)
			{
			}

			// Token: 0x17001A3D RID: 6717
			// (get) Token: 0x0600D795 RID: 55189 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D796 RID: 55190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A3D")]
			public Entity source
			{
				[Token(Token = "0x600D795")]
				[Address(RVA = "0x35C99B0", Offset = "0x35C85B0", VA = "0x1835C99B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D796")]
				[Address(RVA = "0x35C9F30", Offset = "0x35C8B30", VA = "0x1835C9F30")]
				set
				{
				}
			}

			// Token: 0x17001A3E RID: 6718
			// (get) Token: 0x0600D797 RID: 55191 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D798 RID: 55192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A3E")]
			public Entity target
			{
				[Token(Token = "0x600D797")]
				[Address(RVA = "0x35C9A00", Offset = "0x35C8600", VA = "0x1835C9A00")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D798")]
				[Address(RVA = "0x35C9FC0", Offset = "0x35C8BC0", VA = "0x1835C9FC0")]
				set
				{
				}
			}

			// Token: 0x17001A3F RID: 6719
			// (get) Token: 0x0600D799 RID: 55193 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D79A RID: 55194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A3F")]
			public Buff buff
			{
				[Token(Token = "0x600D799")]
				[Address(RVA = "0x35C9790", Offset = "0x35C8390", VA = "0x1835C9790")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D79A")]
				[Address(RVA = "0x35C9BE0", Offset = "0x35C87E0", VA = "0x1835C9BE0")]
				set
				{
				}
			}

			// Token: 0x17001A40 RID: 6720
			// (get) Token: 0x0600D79B RID: 55195 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D79C RID: 55196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A40")]
			public Ability ability
			{
				[Token(Token = "0x600D79B")]
				[Address(RVA = "0x35C96C0", Offset = "0x35C82C0", VA = "0x1835C96C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D79C")]
				[Address(RVA = "0x35C9AA0", Offset = "0x35C86A0", VA = "0x1835C9AA0")]
				set
				{
				}
			}

			// Token: 0x17001A41 RID: 6721
			// (get) Token: 0x0600D79D RID: 55197 RVA: 0x0004DF10 File Offset: 0x0004C110
			// (set) Token: 0x0600D79E RID: 55198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A41")]
			public Modifier modifier
			{
				[Token(Token = "0x600D79D")]
				[Address(RVA = "0x35C9880", Offset = "0x35C8480", VA = "0x1835C9880")]
				get
				{
					return default(Modifier);
				}
				[Token(Token = "0x600D79E")]
				[Address(RVA = "0x35C9D90", Offset = "0x35C8990", VA = "0x1835C9D90")]
				set
				{
				}
			}

			// Token: 0x17001A42 RID: 6722
			// (get) Token: 0x0600D79F RID: 55199 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D7A0 RID: 55200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A42")]
			public Projectile projectile
			{
				[Token(Token = "0x600D79F")]
				[Address(RVA = "0x35C9960", Offset = "0x35C8560", VA = "0x1835C9960")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D7A0")]
				[Address(RVA = "0x35C9EA0", Offset = "0x35C8AA0", VA = "0x1835C9EA0")]
				set
				{
				}
			}

			// Token: 0x17001A43 RID: 6723
			// (get) Token: 0x0600D7A1 RID: 55201 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D7A2 RID: 55202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A43")]
			public Tile tile
			{
				[Token(Token = "0x600D7A1")]
				[Address(RVA = "0x35C9A50", Offset = "0x35C8650", VA = "0x1835C9A50")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D7A2")]
				[Address(RVA = "0x35CA050", Offset = "0x35C8C50", VA = "0x1835CA050")]
				set
				{
				}
			}

			// Token: 0x17001A44 RID: 6724
			// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x0004DF28 File Offset: 0x0004C128
			// (set) Token: 0x0600D7A4 RID: 55204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A44")]
			public BattleFormula.AttackInfo atkInfo
			{
				[Token(Token = "0x600D7A3")]
				[Address(RVA = "0x35C9710", Offset = "0x35C8310", VA = "0x1835C9710")]
				get
				{
					return default(BattleFormula.AttackInfo);
				}
				[Token(Token = "0x600D7A4")]
				[Address(RVA = "0x35C9B30", Offset = "0x35C8730", VA = "0x1835C9B30")]
				set
				{
				}
			}

			// Token: 0x17001A45 RID: 6725
			// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D7A6 RID: 55206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A45")]
			public Entity mainTarget
			{
				[Token(Token = "0x600D7A5")]
				[Address(RVA = "0x35C9830", Offset = "0x35C8430", VA = "0x1835C9830")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D7A6")]
				[Address(RVA = "0x35C9D00", Offset = "0x35C8900", VA = "0x1835C9D00")]
				set
				{
				}
			}

			// Token: 0x17001A46 RID: 6726
			// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D7A8 RID: 55208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A46")]
			public Buff mainBuff
			{
				[Token(Token = "0x600D7A7")]
				[Address(RVA = "0x35C97E0", Offset = "0x35C83E0", VA = "0x1835C97E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D7A8")]
				[Address(RVA = "0x35C9C70", Offset = "0x35C8870", VA = "0x1835C9C70")]
				set
				{
				}
			}

			// Token: 0x0600D7A9 RID: 55209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D7A9")]
			[Address(RVA = "0x35C94D0", Offset = "0x35C80D0", VA = "0x1835C94D0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400E824 RID: 59428
			[Token(Token = "0x400E824")]
			[FieldOffset(Offset = "0x10")]
			private Context m_context;
		}
	}
}

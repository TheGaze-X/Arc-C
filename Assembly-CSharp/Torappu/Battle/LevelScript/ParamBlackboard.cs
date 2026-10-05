using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.ObjectPool;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002836 RID: 10294
	[Token(Token = "0x2002836")]
	public class ParamBlackboard : IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0601123D RID: 70205 RVA: 0x00069900 File Offset: 0x00067B00
		// (set) Token: 0x0601123E RID: 70206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025C6")]
		public uint instanceUid
		{
			[Token(Token = "0x601123D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x601123E")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0601123F RID: 70207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025C7")]
		private static ScopeStack<ParamBlackboard> scopeStack
		{
			[Token(Token = "0x601123F")]
			[Address(RVA = "0x919630", Offset = "0x918230", VA = "0x180919630")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06011240 RID: 70208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025C8")]
		public static ParamBlackboard current
		{
			[Token(Token = "0x6011240")]
			[Address(RVA = "0x9195E0", Offset = "0x9181E0", VA = "0x1809195E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011241 RID: 70209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011241")]
		[Address(RVA = "0x918A20", Offset = "0x917620", VA = "0x180918A20", Slot = "7")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x06011242 RID: 70210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011242")]
		[Address(RVA = "0x918A90", Offset = "0x917690", VA = "0x180918A90", Slot = "8")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x06011243 RID: 70211 RVA: 0x00069918 File Offset: 0x00067B18
		[Token(Token = "0x6011243")]
		[Address(RVA = "0x918BF0", Offset = "0x9177F0", VA = "0x180918BF0")]
		public static ScopeStack<ParamBlackboard>.Scope<ParamBlackboard> PushContext(ParamBlackboard context)
		{
			return default(ScopeStack<ParamBlackboard>.Scope<ParamBlackboard>);
		}

		// Token: 0x06011244 RID: 70212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011244")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void OnPushContext()
		{
		}

		// Token: 0x06011245 RID: 70213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011245")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		protected virtual void OnPopContext()
		{
		}

		// Token: 0x06011246 RID: 70214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011246")]
		public void SetValue<T>(string key, T value)
		{
		}

		// Token: 0x06011247 RID: 70215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011247")]
		public void SetValue<T>(PropertyPath path, T value)
		{
		}

		// Token: 0x06011248 RID: 70216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011248")]
		public void SetValue<T>(PropertyPath path, List<T> value)
		{
		}

		// Token: 0x06011249 RID: 70217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011249")]
		public T GetValue<T>(string key, [Optional] T defaultValue, bool showWarning = true)
		{
			return null;
		}

		// Token: 0x0601124A RID: 70218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601124A")]
		[Address(RVA = "0x918DC0", Offset = "0x9179C0", VA = "0x180918DC0")]
		public void SetVariable(List<ParamKeyValue> paramList, bool isServerOperate = false)
		{
		}

		// Token: 0x0601124B RID: 70219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601124B")]
		[Address(RVA = "0x918CA0", Offset = "0x9178A0", VA = "0x180918CA0")]
		public void SetVariable(ParamKeyValue paramKeyValue, bool isServerOperate = false)
		{
		}

		// Token: 0x0601124C RID: 70220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601124C")]
		[Address(RVA = "0x918FD0", Offset = "0x917BD0", VA = "0x180918FD0")]
		public void SetVariable(string key, ParamVariable variable, bool isServerOperate = false)
		{
		}

		// Token: 0x0601124D RID: 70221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601124D")]
		[Address(RVA = "0x918850", Offset = "0x917450", VA = "0x180918850")]
		public void AssignVariable(string key, ParamVariable variable)
		{
		}

		// Token: 0x0601124E RID: 70222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601124E")]
		[Address(RVA = "0x9188C0", Offset = "0x9174C0", VA = "0x1809188C0")]
		public ParamVariable GetParamVariableOrNewOne(string key, Type type)
		{
			return null;
		}

		// Token: 0x0601124F RID: 70223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601124F")]
		public ParamVariable<T> GetParamVariableOrNewOne<T>(string key)
		{
			return null;
		}

		// Token: 0x06011250 RID: 70224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011250")]
		[Address(RVA = "0x9189A0", Offset = "0x9175A0", VA = "0x1809189A0")]
		public ParamVariable NewParamVariable(string key, Type type)
		{
			return null;
		}

		// Token: 0x06011251 RID: 70225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011251")]
		public ParamVariable<T> NewParamVariable<T>(string key, T value)
		{
			return null;
		}

		// Token: 0x06011252 RID: 70226 RVA: 0x00069930 File Offset: 0x00067B30
		[Token(Token = "0x6011252")]
		[Address(RVA = "0x9194A0", Offset = "0x9180A0", VA = "0x1809194A0")]
		public bool TryGetVariable(string key, out ParamVariable value, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x06011253 RID: 70227 RVA: 0x00069948 File Offset: 0x00067B48
		[Token(Token = "0x6011253")]
		public bool TryGetValue<T>(string key, out T value, bool showWarning = false, bool allowConvert = false)
		{
			return default(bool);
		}

		// Token: 0x06011254 RID: 70228 RVA: 0x00069960 File Offset: 0x00067B60
		[Token(Token = "0x6011254")]
		public bool TryGetValue<T>(PropertyPath path, out T value, bool showWarning = false, bool allowConvert = false)
		{
			return default(bool);
		}

		// Token: 0x06011255 RID: 70229 RVA: 0x00069978 File Offset: 0x00067B78
		[Token(Token = "0x6011255")]
		public bool TryGetValue<T>(PropertyPath path, out List<T> value, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x06011256 RID: 70230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011256")]
		[Address(RVA = "0x9190D0", Offset = "0x917CD0", VA = "0x1809190D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06011257 RID: 70231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011257")]
		[Address(RVA = "0x919550", Offset = "0x918150", VA = "0x180919550")]
		public ParamBlackboard()
		{
		}

		// Token: 0x0401332C RID: 78636
		[Token(Token = "0x401332C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x0401332D RID: 78637
		[Token(Token = "0x401332D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, ParamVariable> variableDict;

		// Token: 0x0401332E RID: 78638
		[Token(Token = "0x401332E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ScopeStack<ParamBlackboard> s_scopeStack;

		// Token: 0x04013330 RID: 78640
		[Token(Token = "0x4013330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static StringBuilder s_stringBuilder;
	}
}

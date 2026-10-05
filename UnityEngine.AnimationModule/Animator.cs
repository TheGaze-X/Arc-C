using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/Animator.h")]
	public class Animator : Behaviour
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000091 RID: 145
		[Token(Token = "0x17000030")]
		public extern bool isHuman { [Token(Token = "0x6000091")] [Address(RVA = "0x5918C20", Offset = "0x5917820", VA = "0x185918C20")] [NativeMethod("IsHuman")] [MethodImpl(4096)] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000092 RID: 146
		[Token(Token = "0x17000031")]
		public extern bool hasRootMotion { [Token(Token = "0x6000092")] [Address(RVA = "0x5918BE0", Offset = "0x59177E0", VA = "0x185918BE0")] [NativeMethod("HasRootMotion")] [MethodImpl(4096)] get; }

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x59188F0", Offset = "0x59174F0", VA = "0x1859188F0")]
		public void SetFloat(string name, float value)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x5918890", Offset = "0x5917490", VA = "0x185918890")]
		public void SetBool(string name, bool value)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x5918830", Offset = "0x5917430", VA = "0x185918830")]
		public void SetBool(int id, bool value)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x5918290", Offset = "0x5916E90", VA = "0x185918290")]
		public int GetInteger(string name)
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x59189A0", Offset = "0x59175A0", VA = "0x1859189A0")]
		public void SetInteger(string name, int value)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x5918950", Offset = "0x5917550", VA = "0x185918950")]
		public void SetInteger(int id, int value)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x5918A40", Offset = "0x5917640", VA = "0x185918A40")]
		public void SetTrigger(string name)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5918A00", Offset = "0x5917600", VA = "0x185918A00")]
		public void SetTrigger(int id)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x59187E0", Offset = "0x59173E0", VA = "0x1859187E0")]
		public void ResetTrigger(string name)
		{
		}

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x0600009C RID: 156
		[Token(Token = "0x17000032")]
		public extern AnimatorUpdateMode updateMode { [Token(Token = "0x600009C")] [Address(RVA = "0x5918E40", Offset = "0x5917A40", VA = "0x185918E40")] [MethodImpl(4096)] set; }

		// Token: 0x0600009D RID: 157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600009D")]
		private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) where T : StateMachineBehaviour
		{
			return null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600009E")]
		public T[] GetBehaviours<T>() where T : StateMachineBehaviour
		{
			return null;
		}

		// Token: 0x0600009F RID: 159
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x5918500", Offset = "0x5917100", VA = "0x185918500")]
		[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern ScriptableObject[] InternalGetBehaviours([NotNull("ArgumentNullException")] Type type);

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A0 RID: 160
		[Token(Token = "0x17000033")]
		public extern int layerCount { [Token(Token = "0x60000A0")] [Address(RVA = "0x5918CA0", Offset = "0x59178A0", VA = "0x185918CA0")] [MethodImpl(4096)] get; }

		// Token: 0x060000A1 RID: 161
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x59182E0", Offset = "0x5916EE0", VA = "0x1859182E0")]
		[MethodImpl(4096)]
		public extern string GetLayerName(int layerIndex);

		// Token: 0x060000A2 RID: 162
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x5918320", Offset = "0x5916F20", VA = "0x185918320")]
		[MethodImpl(4096)]
		public extern float GetLayerWeight(int layerIndex);

		// Token: 0x060000A3 RID: 163
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5918050", Offset = "0x5916C50", VA = "0x185918050")]
		[MethodImpl(4096)]
		private extern void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info);

		// Token: 0x060000A4 RID: 164 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x59181F0", Offset = "0x5916DF0", VA = "0x1859181F0")]
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5918460", Offset = "0x5917060", VA = "0x185918460")]
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		// Token: 0x060000A6 RID: 166
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5917F80", Offset = "0x5916B80", VA = "0x185917F80")]
		[MethodImpl(4096)]
		internal extern int GetAnimatorClipInfoCount(int layerIndex, bool current);

		// Token: 0x060000A7 RID: 167 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x59180B0", Offset = "0x5916CB0", VA = "0x1859180B0")]
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return 0;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5918360", Offset = "0x5916F60", VA = "0x185918360")]
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return 0;
		}

		// Token: 0x060000A9 RID: 169
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x59181B0", Offset = "0x5916DB0", VA = "0x1859181B0")]
		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x5918100", Offset = "0x5916D00", VA = "0x185918100")]
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
		}

		// Token: 0x060000AB RID: 171
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5917FE0", Offset = "0x5916BE0", VA = "0x185917FE0")]
		[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x59183B0", Offset = "0x5916FB0", VA = "0x1859183B0")]
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
		}

		// Token: 0x060000AD RID: 173
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x5918550", Offset = "0x5917150", VA = "0x185918550")]
		[MethodImpl(4096)]
		public extern bool IsInTransition(int layerIndex);

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AE RID: 174
		[Token(Token = "0x17000034")]
		public extern AnimatorControllerParameter[] parameters { [Token(Token = "0x60000AE")] [Address(RVA = "0x5918D20", Offset = "0x5917920", VA = "0x185918D20")] [FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AF RID: 175
		[Token(Token = "0x17000035")]
		public extern int parameterCount { [Token(Token = "0x60000AF")] [Address(RVA = "0x5918CE0", Offset = "0x59178E0", VA = "0x185918CE0")] [MethodImpl(4096)] get; }

		// Token: 0x17000036 RID: 54
		// (set) Token: 0x060000B0 RID: 176
		[Token(Token = "0x17000036")]
		public extern float speed { [Token(Token = "0x60000B0")] [Address(RVA = "0x5918DF0", Offset = "0x59179F0", VA = "0x185918DF0")] [MethodImpl(4096)] set; }

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x5918590", Offset = "0x5917190", VA = "0x185918590")]
		public void Play(string stateName)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5918670", Offset = "0x5917270", VA = "0x185918670")]
		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		// Token: 0x060000B3 RID: 179
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x5918610", Offset = "0x5917210", VA = "0x185918610")]
		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5918700", Offset = "0x5917300", VA = "0x185918700")]
		public void Play(int stateNameHash)
		{
		}

		// Token: 0x060000B5 RID: 181
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5918A90", Offset = "0x5917690", VA = "0x185918A90")]
		[MethodImpl(4096)]
		public extern void StopPlayback();

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B6 RID: 182
		// (set) Token: 0x060000B7 RID: 183
		[Token(Token = "0x17000037")]
		public extern RuntimeAnimatorController runtimeAnimatorController { [Token(Token = "0x60000B6")] [Address(RVA = "0x5918D60", Offset = "0x5917960", VA = "0x185918D60")] [MethodImpl(4096)] get; [Token(Token = "0x60000B7")] [Address(RVA = "0x5918DA0", Offset = "0x59179A0", VA = "0x185918DA0")] [MethodImpl(4096)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B8 RID: 184
		[Token(Token = "0x17000038")]
		public extern bool hasBoundPlayables { [Token(Token = "0x60000B8")] [Address(RVA = "0x5918BA0", Offset = "0x59177A0", VA = "0x185918BA0")] [NativeMethod("HasBoundPlayables")] [MethodImpl(4096)] get; }

		// Token: 0x060000B9 RID: 185
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5918AD0", Offset = "0x59176D0", VA = "0x185918AD0")]
		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern int StringToHash(string name);

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BA RID: 186
		[Token(Token = "0x17000039")]
		public extern Avatar avatar { [Token(Token = "0x60000BA")] [Address(RVA = "0x5918B60", Offset = "0x5917760", VA = "0x185918B60")] [MethodImpl(4096)] get; }

		// Token: 0x060000BB RID: 187
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x59188F0", Offset = "0x59174F0", VA = "0x1859188F0")]
		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetFloatString(string name, float value);

		// Token: 0x060000BC RID: 188
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5918890", Offset = "0x5917490", VA = "0x185918890")]
		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetBoolString(string name, bool value);

		// Token: 0x060000BD RID: 189
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5918830", Offset = "0x5917430", VA = "0x185918830")]
		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetBoolID(int id, bool value);

		// Token: 0x060000BE RID: 190
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x59189A0", Offset = "0x59175A0", VA = "0x1859189A0")]
		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetIntegerString(string name, int value);

		// Token: 0x060000BF RID: 191
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5918950", Offset = "0x5917550", VA = "0x185918950")]
		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetIntegerID(int id, int value);

		// Token: 0x060000C0 RID: 192
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5918290", Offset = "0x5916E90", VA = "0x185918290")]
		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int GetIntegerString(string name);

		// Token: 0x060000C1 RID: 193
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5918A40", Offset = "0x5917640", VA = "0x185918A40")]
		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetTriggerString(string name);

		// Token: 0x060000C2 RID: 194
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5918A00", Offset = "0x5917600", VA = "0x185918A00")]
		[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetTriggerID(int id);

		// Token: 0x060000C3 RID: 195
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x59187E0", Offset = "0x59173E0", VA = "0x1859187E0")]
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void ResetTriggerString(string name);

		// Token: 0x060000C4 RID: 196
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x5918B10", Offset = "0x5917710", VA = "0x185918B10")]
		[NativeMethod("UpdateWithDelta")]
		[MethodImpl(4096)]
		public extern void Update(float deltaTime);

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5918750", Offset = "0x5917350", VA = "0x185918750")]
		public void Rebind()
		{
		}

		// Token: 0x060000C6 RID: 198
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5918790", Offset = "0x5917390", VA = "0x185918790")]
		[MethodImpl(4096)]
		private extern void Rebind(bool writeDefaultValues);

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C7 RID: 199
		[Token(Token = "0x1700003A")]
		public extern bool keepAnimatorStateOnDisable { [Token(Token = "0x60000C7")] [Address(RVA = "0x5918C60", Offset = "0x5917860", VA = "0x185918C60")] [MethodImpl(4096)] get; }

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x060000C8 RID: 200
		[Token(Token = "0x1700003B")]
		public extern bool writeDefaultValuesOnDisable { [Token(Token = "0x60000C8")] [Address(RVA = "0x5918E80", Offset = "0x5917A80", VA = "0x185918E80")] [MethodImpl(4096)] set; }

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Animator()
		{
		}
	}
}

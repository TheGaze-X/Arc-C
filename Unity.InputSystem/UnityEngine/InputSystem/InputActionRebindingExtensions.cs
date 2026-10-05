using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public static class InputActionRebindingExtensions
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x55D7D00", Offset = "0x55D6900", VA = "0x1855D7D00")]
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, [Optional] InputBinding bindingMask)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x55D7F80", Offset = "0x55D6B80", VA = "0x1855D7F80")]
		private static PrimitiveValue? GetParameterValue(this InputAction action, InputActionRebindingExtensions.ParameterOverride parameterOverride)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x55D83A0", Offset = "0x55D6FA0", VA = "0x1855D83A0")]
		public static PrimitiveValue? GetParameterValue(this InputAction action, string name, int bindingIndex)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001F8")]
		public static TValue? GetParameterValue<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, [Optional] InputBinding bindingMask) where TValue : struct
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		public static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, [Optional] InputBinding bindingMask) where TValue : struct
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, [Optional] InputBinding bindingMask) where TValue : struct
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		public static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, [Optional] InputBinding bindingMask) where TValue : struct
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001FC")]
		private static InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, [Optional] InputBinding bindingMask, [Optional] PrimitiveValue value)
		{
			return default(InputActionRebindingExtensions.ParameterOverride);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x55D5B40", Offset = "0x55D4740", VA = "0x1855D5B40")]
		public static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, [Optional] InputBinding bindingMask)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x55D6100", Offset = "0x55D4D00", VA = "0x1855D6100")]
		public static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, [Optional] InputBinding bindingMask)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x55D5830", Offset = "0x55D4430", VA = "0x1855D5830")]
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, [Optional] InputBinding bindingMask)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x55D5E10", Offset = "0x55D4A10", VA = "0x1855D5E10")]
		public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x55D4D90", Offset = "0x55D3990", VA = "0x1855D4D90")]
		private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref InputActionRebindingExtensions.ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, InputActionRebindingExtensions.ParameterOverride parameterOverride)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x55D76E0", Offset = "0x55D62E0", VA = "0x1855D76E0")]
		public static int GetBindingIndex(this InputAction action, InputBinding bindingMask)
		{
			return 0;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x55D7B50", Offset = "0x55D6750", VA = "0x1855D7B50")]
		public static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask)
		{
			return 0;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x55D78E0", Offset = "0x55D64E0", VA = "0x1855D78E0")]
		public static int GetBindingIndex(this InputAction action, [Optional] string group, [Optional] string path)
		{
			return 0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x55D7230", Offset = "0x55D5E30", VA = "0x1855D7230")]
		public static InputBinding? GetBindingForControl(this InputAction action, InputControl control)
		{
			return null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x55D74D0", Offset = "0x55D60D0", VA = "0x1855D74D0")]
		public static int GetBindingIndexForControl(this InputAction action, InputControl control)
		{
			return 0;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x55D6CD0", Offset = "0x55D58D0", VA = "0x1855D6CD0")]
		public static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0, [Optional] string group)
		{
			return null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x55D6F30", Offset = "0x55D5B30", VA = "0x1855D6F30")]
		public static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x55D6550", Offset = "0x55D5150", VA = "0x1855D6550")]
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x55D65E0", Offset = "0x55D51E0", VA = "0x1855D65E0")]
		public static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x55D3C90", Offset = "0x55D2890", VA = "0x1855D3C90")]
		public static void ApplyBindingOverride(this InputAction action, string newPath, [Optional] string group, [Optional] string path)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x55D3FA0", Offset = "0x55D2BA0", VA = "0x1855D3FA0")]
		public static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x55D4250", Offset = "0x55D2E50", VA = "0x1855D4250")]
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x55D3DC0", Offset = "0x55D29C0", VA = "0x1855D3DC0")]
		public static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x55D4350", Offset = "0x55D2F50", VA = "0x1855D4350")]
		public static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride)
		{
			return 0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x55D4500", Offset = "0x55D3100", VA = "0x1855D4500")]
		public static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x55D9970", Offset = "0x55D8570", VA = "0x1855D9970")]
		public static void RemoveBindingOverride(this InputAction action, int bindingIndex)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x55D9870", Offset = "0x55D8470", VA = "0x1855D9870")]
		public static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x55D9AB0", Offset = "0x55D86B0", VA = "0x1855D9AB0")]
		private static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x55D93A0", Offset = "0x55D7FA0", VA = "0x1855D93A0")]
		public static void RemoveAllBindingOverrides(this IInputActionCollection2 actions)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x55D96D0", Offset = "0x55D82D0", VA = "0x1855D96D0")]
		public static void RemoveAllBindingOverrides(this InputAction action)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x55D4AC0", Offset = "0x55D36C0", VA = "0x1855D4AC0")]
		public static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x55D9BB0", Offset = "0x55D87B0", VA = "0x1855D9BB0")]
		public static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x55D4890", Offset = "0x55D3490", VA = "0x1855D4890")]
		public static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control)
		{
			return 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x55D4700", Offset = "0x55D3300", VA = "0x1855D4700")]
		public static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control)
		{
			return 0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x55D9F10", Offset = "0x55D8B10", VA = "0x1855D9F10")]
		public static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x55DA290", Offset = "0x55D8E90", VA = "0x1855DA290")]
		public static string SaveBindingOverridesAsJson(this InputAction action)
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x55D3A20", Offset = "0x55D2620", VA = "0x1855D3A20")]
		private static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, [Optional] InputAction action)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x55D8B70", Offset = "0x55D7770", VA = "0x1855D8B70")]
		public static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x55D8C90", Offset = "0x55D7890", VA = "0x1855D8C90")]
		public static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x55D8690", Offset = "0x55D7290", VA = "0x1855D8690")]
		private static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x55D8DC0", Offset = "0x55D79C0", VA = "0x1855D8DC0")]
		public static InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1)
		{
			return null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x55D6480", Offset = "0x55D5080", VA = "0x1855D6480")]
		internal static InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution()
		{
			return null;
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		internal struct Parameter
		{
			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object instance;

			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FieldInfo field;

			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int bindingIndex;
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		private struct ParameterEnumerable : IEnumerable<InputActionRebindingExtensions.Parameter>, IEnumerable
		{
			// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x55DDE80", Offset = "0x55DCA80", VA = "0x1855DDE80")]
			public ParameterEnumerable(InputActionState state, InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex = -1)
			{
			}

			// Token: 0x06000223 RID: 547 RVA: 0x00002970 File Offset: 0x00000B70
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x55DDBB0", Offset = "0x55DC7B0", VA = "0x1855DDBB0")]
			public InputActionRebindingExtensions.ParameterEnumerator GetEnumerator()
			{
				return default(InputActionRebindingExtensions.ParameterEnumerator);
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x55DDCE0", Offset = "0x55DC8E0", VA = "0x1855DDCE0", Slot = "4")]
			private IEnumerator<InputActionRebindingExtensions.Parameter> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000225 RID: 549 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x55DDDB0", Offset = "0x55DC9B0", VA = "0x1855DDDB0", Slot = "5")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private InputActionState m_State;

			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private InputActionRebindingExtensions.ParameterOverride m_Parameter;

			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private int m_MapIndex;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		private struct ParameterEnumerator : IEnumerator<InputActionRebindingExtensions.Parameter>, IEnumerator, IDisposable
		{
			// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x55DE5D0", Offset = "0x55DD1D0", VA = "0x1855DE5D0")]
			public ParameterEnumerator(InputActionState state, InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex = -1)
			{
			}

			// Token: 0x06000227 RID: 551 RVA: 0x00002988 File Offset: 0x00000B88
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x55DE1E0", Offset = "0x55DCDE0", VA = "0x1855DE1E0")]
			private bool MoveToNextBinding()
			{
				return default(bool);
			}

			// Token: 0x06000228 RID: 552 RVA: 0x000029A0 File Offset: 0x00000BA0
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x55DE370", Offset = "0x55DCF70", VA = "0x1855DE370")]
			private bool MoveToNextInteraction()
			{
				return default(bool);
			}

			// Token: 0x06000229 RID: 553 RVA: 0x000029B8 File Offset: 0x00000BB8
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x55DE3E0", Offset = "0x55DCFE0", VA = "0x1855DE3E0")]
			private bool MoveToNextProcessor()
			{
				return default(bool);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x000029D0 File Offset: 0x00000BD0
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x55DDF10", Offset = "0x55DCB10", VA = "0x1855DDF10")]
			private bool FindParameter(object instance)
			{
				return default(bool);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x000029E8 File Offset: 0x00000BE8
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x55DE070", Offset = "0x55DCC70", VA = "0x1855DE070", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x55DE450", Offset = "0x55DD050", VA = "0x1855DE450", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600022D RID: 557 RVA: 0x00002A00 File Offset: 0x00000C00
			[Token(Token = "0x170000C1")]
			public InputActionRebindingExtensions.Parameter Current
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0x55DE8F0", Offset = "0x55DD4F0", VA = "0x1855DE8F0", Slot = "4")]
				get
				{
					return default(InputActionRebindingExtensions.Parameter);
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600022E RID: 558 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000C2")]
			private object Current
			{
				[Token(Token = "0x600022E")]
				[Address(RVA = "0x55DE540", Offset = "0x55DD140", VA = "0x1855DE540", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private InputActionState m_State;

			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int m_MapIndex;

			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int m_BindingCurrentIndex;

			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_BindingEndIndex;

			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_InteractionCurrentIndex;

			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_InteractionEndIndex;

			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_ProcessorCurrentIndex;

			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ProcessorEndIndex;

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private InputBinding m_BindingMask;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Type m_ObjectType;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private string m_ParameterName;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool m_MayBeInteraction;

			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
			private bool m_MayBeProcessor;

			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
			private bool m_MayBeComposite;

			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
			private bool m_CurrentBindingIsComposite;

			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private object m_CurrentObject;

			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private FieldInfo m_CurrentParameter;
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		internal struct ParameterOverride
		{
			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000230 RID: 560 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000C3")]
			public Type objectType
			{
				[Token(Token = "0x6000230")]
				[Address(RVA = "0x55DF670", Offset = "0x55DE270", VA = "0x1855DF670")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x55DF570", Offset = "0x55DE170", VA = "0x1855DF570")]
			public ParameterOverride(string parameterName, InputBinding bindingMask, [Optional] PrimitiveValue value)
			{
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x55DF4E0", Offset = "0x55DE0E0", VA = "0x1855DF4E0")]
			public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, [Optional] PrimitiveValue value)
			{
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00002A18 File Offset: 0x00000C18
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x55DED80", Offset = "0x55DD980", VA = "0x1855DED80")]
			public static InputActionRebindingExtensions.ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName)
			{
				return null;
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00002A30 File Offset: 0x00000C30
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x55DE950", Offset = "0x55DD550", VA = "0x1855DE950")]
			private static InputActionRebindingExtensions.ParameterOverride? Find(InputActionRebindingExtensions.ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName)
			{
				return null;
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00002A48 File Offset: 0x00000C48
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x55DF060", Offset = "0x55DDC60", VA = "0x1855DF060")]
			private static InputActionRebindingExtensions.ParameterOverride? PickMoreSpecificOne(InputActionRebindingExtensions.ParameterOverride? first, InputActionRebindingExtensions.ParameterOverride? second)
			{
				return null;
			}

			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string objectRegistrationName;

			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string parameter;

			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputBinding bindingMask;

			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public PrimitiveValue value;
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		public sealed class RebindingOperation : IDisposable
		{
			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000236 RID: 566 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000C4")]
			public InputAction action
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000237 RID: 567 RVA: 0x00002A60 File Offset: 0x00000C60
			[Token(Token = "0x170000C5")]
			public InputBinding? bindingMask
			{
				[Token(Token = "0x6000237")]
				[Address(RVA = "0x55E3EB0", Offset = "0x55E2AB0", VA = "0x1855E3EB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000238 RID: 568 RVA: 0x00002A78 File Offset: 0x00000C78
			[Token(Token = "0x170000C6")]
			public InputControlList<InputControl> candidates
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x55E3F00", Offset = "0x55E2B00", VA = "0x1855E3F00")]
				get
				{
					return default(InputControlList<InputControl>);
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000239 RID: 569 RVA: 0x00002A90 File Offset: 0x00000C90
			[Token(Token = "0x170000C7")]
			public ReadOnlyArray<float> scores
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x55E3FE0", Offset = "0x55E2BE0", VA = "0x1855E3FE0")]
				get
				{
					return default(ReadOnlyArray<float>);
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600023A RID: 570 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x170000C8")]
			public ReadOnlyArray<float> magnitudes
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x55E3F60", Offset = "0x55E2B60", VA = "0x1855E3F60")]
				get
				{
					return default(ReadOnlyArray<float>);
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000C9")]
			public InputControl selectedControl
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x55E4060", Offset = "0x55E2C60", VA = "0x1855E4060")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600023C RID: 572 RVA: 0x00002AC0 File Offset: 0x00000CC0
			[Token(Token = "0x170000CA")]
			public bool started
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x55E40D0", Offset = "0x55E2CD0", VA = "0x1855E40D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600023D RID: 573 RVA: 0x00002AD8 File Offset: 0x00000CD8
			[Token(Token = "0x170000CB")]
			public bool completed
			{
				[Token(Token = "0x600023D")]
				[Address(RVA = "0x55E3F20", Offset = "0x55E2B20", VA = "0x1855E3F20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x0600023E RID: 574 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[Token(Token = "0x170000CC")]
			public bool canceled
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0x55E3EF0", Offset = "0x55E2AF0", VA = "0x1855E3EF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x0600023F RID: 575 RVA: 0x00002B08 File Offset: 0x00000D08
			[Token(Token = "0x170000CD")]
			public double startTime
			{
				[Token(Token = "0x600023F")]
				[Address(RVA = "0x55E40C0", Offset = "0x55E2CC0", VA = "0x1855E40C0")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000240 RID: 576 RVA: 0x00002B20 File Offset: 0x00000D20
			[Token(Token = "0x170000CE")]
			public float timeout
			{
				[Token(Token = "0x6000240")]
				[Address(RVA = "0x55E40E0", Offset = "0x55E2CE0", VA = "0x1855E40E0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x06000241 RID: 577 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000CF")]
			public string expectedControlType
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x55E3F30", Offset = "0x55E2B30", VA = "0x1855E3F30")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x55E2980", Offset = "0x55E1580", VA = "0x1855E2980")]
			public InputActionRebindingExtensions.RebindingOperation WithAction(InputAction action)
			{
				return null;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x55E3510", Offset = "0x55E2110", VA = "0x1855E3510")]
			public InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true)
			{
				return null;
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x55E2CE0", Offset = "0x55E18E0", VA = "0x1855E2CE0")]
			public InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(string binding)
			{
				return null;
			}

			// Token: 0x06000245 RID: 581 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x55E2D60", Offset = "0x55E1960", VA = "0x1855E2D60")]
			public InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(InputControl control)
			{
				return null;
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x55E3350", Offset = "0x55E1F50", VA = "0x1855E3350")]
			public InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(string layoutName)
			{
				return null;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x55E3160", Offset = "0x55E1D60", VA = "0x1855E3160")]
			public InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(Type type)
			{
				return null;
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000248")]
			public InputActionRebindingExtensions.RebindingOperation WithExpectedControlType<TControl>() where TControl : InputControl
			{
				return null;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x55E35D0", Offset = "0x55E21D0", VA = "0x1855E35D0")]
			public InputActionRebindingExtensions.RebindingOperation WithTargetBinding(int bindingIndex)
			{
				return null;
			}

			// Token: 0x0600024A RID: 586 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x55E2C90", Offset = "0x55E1890", VA = "0x1855E2C90")]
			public InputActionRebindingExtensions.RebindingOperation WithBindingMask(InputBinding? bindingMask)
			{
				return null;
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x55E2B60", Offset = "0x55E1760", VA = "0x1855E2B60")]
			public InputActionRebindingExtensions.RebindingOperation WithBindingGroup(string group)
			{
				return null;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x55E3D80", Offset = "0x55E2980", VA = "0x1855E3D80")]
			public InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl()
			{
				return null;
			}

			// Token: 0x0600024D RID: 589 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x55E35A0", Offset = "0x55E21A0", VA = "0x1855E35A0")]
			public InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding([Optional] string group)
			{
				return null;
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x55E33F0", Offset = "0x55E1FF0", VA = "0x1855E33F0")]
			public InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude)
			{
				return null;
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x55E3D90", Offset = "0x55E2990", VA = "0x1855E3D90")]
			public InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls()
			{
				return null;
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x55E2FD0", Offset = "0x55E1BD0", VA = "0x1855E2FD0")]
			public InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(string path)
			{
				return null;
			}

			// Token: 0x06000251 RID: 593 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x55E2E40", Offset = "0x55E1A40", VA = "0x1855E2E40")]
			public InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(string path)
			{
				return null;
			}

			// Token: 0x06000252 RID: 594 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x55E3D70", Offset = "0x55E2970", VA = "0x1855E3D70")]
			public InputActionRebindingExtensions.RebindingOperation WithTimeout(float timeInSeconds)
			{
				return null;
			}

			// Token: 0x06000253 RID: 595 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x55E1780", Offset = "0x55E0380", VA = "0x1855E1780")]
			public InputActionRebindingExtensions.RebindingOperation OnComplete(Action<InputActionRebindingExtensions.RebindingOperation> callback)
			{
				return null;
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x55E1280", Offset = "0x55DFE80", VA = "0x1855E1280")]
			public InputActionRebindingExtensions.RebindingOperation OnCancel(Action<InputActionRebindingExtensions.RebindingOperation> callback)
			{
				return null;
			}

			// Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x55E1FD0", Offset = "0x55E0BD0", VA = "0x1855E1FD0")]
			public InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(Action<InputActionRebindingExtensions.RebindingOperation> callback)
			{
				return null;
			}

			// Token: 0x06000256 RID: 598 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x55E1F90", Offset = "0x55E0B90", VA = "0x1855E1F90")]
			public InputActionRebindingExtensions.RebindingOperation OnGeneratePath(Func<InputControl, string> callback)
			{
				return null;
			}

			// Token: 0x06000257 RID: 599 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x55E17B0", Offset = "0x55E03B0", VA = "0x1855E17B0")]
			public InputActionRebindingExtensions.RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback)
			{
				return null;
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x55E1210", Offset = "0x55DFE10", VA = "0x1855E1210")]
			public InputActionRebindingExtensions.RebindingOperation OnApplyBinding(Action<InputActionRebindingExtensions.RebindingOperation, string> callback)
			{
				return null;
			}

			// Token: 0x06000259 RID: 601 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x55E1FC0", Offset = "0x55E0BC0", VA = "0x1855E1FC0")]
			public InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(float seconds)
			{
				return null;
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x55E2470", Offset = "0x55E1070", VA = "0x1855E2470")]
			public InputActionRebindingExtensions.RebindingOperation Start()
			{
				return null;
			}

			// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x55E0B60", Offset = "0x55DF760", VA = "0x1855E0B60")]
			public void Cancel()
			{
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x55E0BB0", Offset = "0x55DF7B0", VA = "0x1855E0BB0")]
			public void Complete()
			{
			}

			// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x55E09A0", Offset = "0x55DF5A0", VA = "0x1855E09A0")]
			public void AddCandidate(InputControl control, float score, float magnitude = -1f)
			{
			}

			// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x55E2000", Offset = "0x55E0C00", VA = "0x1855E2000")]
			public void RemoveCandidate(InputControl control)
			{
			}

			// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x55E0BD0", Offset = "0x55DF7D0", VA = "0x1855E0BD0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x55E0C90", Offset = "0x55DF890", VA = "0x1855E0C90", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x55E2230", Offset = "0x55E0E30", VA = "0x1855E2230")]
			public InputActionRebindingExtensions.RebindingOperation Reset()
			{
				return null;
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x55E1050", Offset = "0x55DFC50", VA = "0x1855E1050")]
			private void HookOnEvent()
			{
			}

			// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x55E2900", Offset = "0x55E1500", VA = "0x1855E2900")]
			private void UnhookOnEvent()
			{
			}

			// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x55E17E0", Offset = "0x55E03E0", VA = "0x1855E17E0")]
			private void OnEvent(InputEventPtr eventPtr, InputDevice device)
			{
			}

			// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x55E2350", Offset = "0x55E0F50", VA = "0x1855E2350")]
			private void SortCandidatesByScore()
			{
			}

			// Token: 0x06000266 RID: 614 RVA: 0x00002B38 File Offset: 0x00000D38
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x55E0EF0", Offset = "0x55DFAF0", VA = "0x1855E0EF0")]
			private static bool HavePathMatch(InputControl control, string[] paths, int pathCount)
			{
				return default(bool);
			}

			// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x55E0F70", Offset = "0x55DFB70", VA = "0x1855E0F70")]
			private void HookOnAfterUpdate()
			{
			}

			// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x55E2890", Offset = "0x55E1490", VA = "0x1855E2890")]
			private void UnhookOnAfterUpdate()
			{
			}

			// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x55E1150", Offset = "0x55DFD50", VA = "0x1855E1150")]
			private void OnAfterUpdate()
			{
			}

			// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x55E12B0", Offset = "0x55DFEB0", VA = "0x1855E12B0")]
			private void OnComplete()
			{
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x55E1240", Offset = "0x55DFE40", VA = "0x1855E1240")]
			private void OnCancel()
			{
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x55E2120", Offset = "0x55E0D20", VA = "0x1855E2120")]
			private void ResetAfterMatchCompleted()
			{
			}

			// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x55E2820", Offset = "0x55E1420", VA = "0x1855E2820")]
			private void ThrowIfRebindInProgress()
			{
			}

			// Token: 0x0600026E RID: 622 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x55E0D90", Offset = "0x55DF990", VA = "0x1855E0D90")]
			private string GeneratePathForControl(InputControl control)
			{
				return null;
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x55E3E10", Offset = "0x55E2A10", VA = "0x1855E3E10")]
			public RebindingOperation()
			{
			}

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			public const float kDefaultMagnitudeThreshold = 0.2f;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private InputAction m_ActionToRebind;

			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private InputBinding? m_BindingMask;

			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Type m_ControlType;

			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private InternedString m_ExpectedLayout;

			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int m_IncludePathCount;

			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private string[] m_IncludePaths;

			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int m_ExcludePathCount;

			// Token: 0x04000128 RID: 296
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private string[] m_ExcludePaths;

			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int m_TargetBindingIndex;

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private string m_BindingGroupForNewBinding;

			// Token: 0x0400012B RID: 299
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private string m_CancelBinding;

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private float m_MagnitudeThreshold;

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private float[] m_Scores;

			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private float[] m_Magnitudes;

			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private double m_LastMatchTime;

			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private double m_StartTime;

			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private float m_Timeout;

			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private float m_WaitSecondsAfterMatch;

			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private InputControlList<InputControl> m_Candidates;

			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Action<InputActionRebindingExtensions.RebindingOperation> m_OnComplete;

			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Action<InputActionRebindingExtensions.RebindingOperation> m_OnCancel;

			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Action<InputActionRebindingExtensions.RebindingOperation> m_OnPotentialMatch;

			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Func<InputControl, string> m_OnGeneratePath;

			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Func<InputControl, InputEventPtr, float> m_OnComputeScore;

			// Token: 0x04000139 RID: 313
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Action<InputActionRebindingExtensions.RebindingOperation, string> m_OnApplyBinding;

			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private Action<InputEventPtr, InputDevice> m_OnEventDelegate;

			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private Action m_OnAfterUpdateDelegate;

			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private InputControlLayout.Cache m_LayoutCache;

			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private StringBuilder m_PathBuilder;

			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private InputActionRebindingExtensions.RebindingOperation.Flags m_Flags;

			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private Dictionary<InputControl, float> m_StartingActuations;

			// Token: 0x02000035 RID: 53
			[Token(Token = "0x2000035")]
			[Flags]
			private enum Flags
			{
				// Token: 0x04000141 RID: 321
				[Token(Token = "0x4000141")]
				Started = 1,
				// Token: 0x04000142 RID: 322
				[Token(Token = "0x4000142")]
				Completed = 2,
				// Token: 0x04000143 RID: 323
				[Token(Token = "0x4000143")]
				Canceled = 4,
				// Token: 0x04000144 RID: 324
				[Token(Token = "0x4000144")]
				OnEventHooked = 8,
				// Token: 0x04000145 RID: 325
				[Token(Token = "0x4000145")]
				OnAfterUpdateHooked = 16,
				// Token: 0x04000146 RID: 326
				[Token(Token = "0x4000146")]
				DontIgnoreNoisyControls = 64,
				// Token: 0x04000147 RID: 327
				[Token(Token = "0x4000147")]
				DontGeneralizePathOfSelectedControl = 128,
				// Token: 0x04000148 RID: 328
				[Token(Token = "0x4000148")]
				AddNewBinding = 256,
				// Token: 0x04000149 RID: 329
				[Token(Token = "0x4000149")]
				SuppressMatchingEvents = 512
			}
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		internal class DeferBindingResolutionWrapper : IDisposable
		{
			// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x55E8B00", Offset = "0x55E7700", VA = "0x1855E8B00")]
			public void Acquire()
			{
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x55E8B40", Offset = "0x55E7740", VA = "0x1855E8B40", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DeferBindingResolutionWrapper()
			{
			}
		}
	}
}

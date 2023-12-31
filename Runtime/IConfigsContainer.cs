using System.Collections.Generic;
using GameLovers;

// ReSharper disable once CheckNamespace

namespace GameLovers.ConfigsProvider
{
	/// <summary>
	/// Generic contract for a config to be serialized in containers
	/// </summary>
	public interface IConfig
	{
		int ConfigId { get; }
	}

	/// <summary>
	/// Generic container of the configs imported with a ConfigsImporter script
	/// The given <typeparamref name="T"/> type is the same of the config struct defined to be serialized in the scriptable object
	/// </summary>
	public interface IConfigsContainer<T>
	{
		List<T> Configs { get; set; }
	}

	/// <summary>
	/// Generic container of the unique single config imported with a ConfigsImporter script
	/// The given <typeparamref name="T"/> type is the same of the config struct defined to be serialized in the scriptable object
	/// </summary>
	public interface ISingleConfigContainer<T>
	{
		T Config { get; set; }
	}

	/// <inheritdoc />
	/// <remarks>
	/// Use this configs container to hold the configs data in pairs mapped by it's given <typeparamref name="TKey"/> id
	/// </remarks>
	public interface IPairConfigsContainer<TKey, TValue> : IConfigsContainer<Pair<TKey, TValue>>
	{
	}

	/// <inheritdoc />
	/// <remarks>
	/// Use this configs container to hold the configs data in pairs mapped by it's given <typeparamref name="TKey"/> id
	/// </remarks>
	public interface IStructPairConfigsContainer<TKey, TValue> : IConfigsContainer<StructPair<TKey, TValue>>
		where TKey : struct
		where TValue : struct
	{
	}
}
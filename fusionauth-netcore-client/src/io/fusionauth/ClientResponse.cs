using System;
using com.inversoft.error;

namespace io.fusionauth {
  public class ClientResponse {
    public int statusCode { get; set; }

    public Errors errorResponse { get; set; }

    public Exception exception { get; set; }

    public bool WasSuccessful() {
      return statusCode == 200;
    }
  }

  public class ClientResponse<T> : ClientResponse {
    public T successResponse { get; set; }
  }
}

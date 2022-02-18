// see More Example https://codeseven.github.io/toastr/demo.html
//This code Writen by Vahid Nasiri 
window.ShowToastr = (type, message) => {
  // Toastr don't work with Bootstrap 4.2
  toastr.options.toastClass = "toastr"; // https://github.com/CodeSeven/toastr/issues/599
 //   toastr.options.positionClass = "toast-top-right";
  if (type === "success") {
    toastr.success(message, "Operation Successful", { timeOut: 2000 });
  }
  if (type === "error") {
    toastr.error(message, "Operation Failed", { timeOut: 2000 });
  }
};
